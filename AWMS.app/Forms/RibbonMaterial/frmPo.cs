using AWMS.core;
using AWMS.core.Interfaces;
using AWMS.dto;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmPo : XtraForm
    {
        private readonly IMrService _MrService;
        private readonly IPoService _PoService;
        private int _highlightedRowHandle = GridControl.InvalidRowHandle;
        public frmPo(IMrService MrService, IPoService PoService)
        {
            InitializeComponent();
            this._MrService = MrService;
            this._PoService = PoService;
            lblPoEnterDate.Text = DateTime.Now.ToString();
            LoadGrid();
            InitializeGrid();
            LoadData();
        }
        private void LoadGrid()
        {
            try
            {
                // Change mouse cursor to wait state
                Cursor.Current = Cursors.WaitCursor;

                // Await the asynchronous operation
                var Pos = _PoService.GetAllPos();
                gridControl1.DataSource = Pos;
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // Set mouse cursor back to default state
                Cursor.Current = Cursors.Default;
            }
        }
        private void InitializeGrid()
        {
            GridView gridView = gridView1;

            if (gridView != null)
            {
                gridView.OptionsSelection.MultiSelect = true;
                gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

                gridView.CellValueChanged += GridView_CellValueChanged;
            }
        }
        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // دریافت داده‌ها
                var Mrs = _MrService.GetMrIdAndName();

                // تنظیم منبع داده برای لوکاپ‌ها
                lookUpEdit1.Properties.DataSource = Mrs;
                repositoryItemLookUpEdit1.DataSource = Mrs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private async void btnAddPo_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 12;

            string poName = txtPoName.Text.Trim();
            string poDescription = txtPoDescription.Text.Trim();
            var selectedMRId = 0;
            DateTime enteredDate = dateEdit1.DateTime != DateTime.MinValue ? dateEdit1.DateTime : DateTime.Now;

            if (lookUpEdit1.EditValue == null || lookUpEdit1.EditValue == DBNull.Value)
            {
                // Default value when nothing is selected
                MessageBox.Show("Please Select a valid Mr Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // User has selected an item, proceed with the original logic
                selectedMRId = Convert.ToInt32(lookUpEdit1.EditValue);
            }

            if (string.IsNullOrWhiteSpace(poName))
            {
                MessageBox.Show("Please enter a valid Po Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                int? duplicateRowHandleNullable = await _PoService.GetByPoNameAsync(poName);
                if (duplicateRowHandleNullable.HasValue)
                {
                    int duplicateRowHandle = gridView1.LocateByValue("PoName", poName);

                    gridView1.ClearSelection();
                    gridView1.SelectRow(duplicateRowHandle);
                    gridView1.FocusedRowHandle = duplicateRowHandle;
                    gridView1.MakeRowVisible(duplicateRowHandle);

                    _highlightedRowHandle = duplicateRowHandle;
                    gridView1.RowStyle += GridView1_DuplicateRowStyle;
                    gridView1.RefreshRow(duplicateRowHandle); // Force the row to refresh its style

                    await Task.Delay(3000);

                    gridView1.RowStyle -= GridView1_DuplicateRowStyle;
                    gridView1.RefreshRow(duplicateRowHandle); // Reset the row style

                    return; // Exit the method if the Mr name is not unique
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("Error: " + ex.Message);
            }

            var newPo = new PoDto()
            {
                MrId = selectedMRId,
                PoName = poName,
                PoDescription = poDescription,
                EnteredDate = enteredDate
            };

            btnAddPo.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await AddPoRecordAsync(newPo);

            btnAddPo.Enabled = true;

            if (isAdded > 0)
            {
                progressBarControl1.Position = 0;

                LoadGrid();

                // Get the handle of the newly added row
                int newRowHandle = gridView1.LocateByValue("PoId", isAdded);

                if (newRowHandle >= 0)
                {
                    gridView1.ClearSelection();
                    gridView1.SelectRow(newRowHandle);
                    gridView1.FocusedRowHandle = newRowHandle;
                    gridView1.MakeRowVisible(newRowHandle);

                    _highlightedRowHandle = newRowHandle;
                    gridView1.RowStyle += GridView1_NewRowStyle;
                    gridView1.RefreshRow(newRowHandle); // Force the row to refresh its style

                    await Task.Delay(3000);

                    gridView1.RowStyle -= GridView1_NewRowStyle;
                    gridView1.RefreshRow(newRowHandle); // Reset the row style
                }
            }
            else
            {
                XtraMessageBox.Show("Failed to add Po record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;
            }
        }
        private void GridView1_DuplicateRowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle == _highlightedRowHandle)
            {
                e.Appearance.BackColor = Color.LightSalmon;
                e.Appearance.Options.UseBackColor = true; // Ensure the background color is used
                e.HighPriority = true; // Ensure this style has higher priority than the default focus style
            }
        }
        private void GridView1_NewRowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle == _highlightedRowHandle)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.Options.UseBackColor = true; // Ensure the background color is used
                e.HighPriority = true; // Ensure this style has higher priority than the default focus style
            }
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i += 5)
            {
                progressBarControl1.Position = i;

                // Simulate a small delay without blocking the UI
                await Task.Delay(10); // Adjust the delay time if needed
            }
        }
        private async Task<int> AddPoRecordAsync(PoDto newPo)
        {
            try
            {
                // Add the Po record to the database asynchronously
                return await Task.Run(() => _PoService.AddPoAsync(newPo));
            }
            catch (Exception)
            {
                // Handle exception (log, throw, etc.)
                return -1;
            }
        }
        private async void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Handle cell value changes for any column
            GridView gridView = sender as GridView;

            // Get the new values
            int newpoId = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "PoId"));
            string newPoName = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "PoName")).Trim();
            string newPoDescription = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "PoDescription")).Trim();
            DateTime newEnteredDate = Convert.ToDateTime(gridView.GetRowCellValue(e.RowHandle, "EnteredDate"));
            var selectedMRId = 0;

            // Retrieve the selected value from repositoryItemLookUpEdit1
            var editValue = gridView.GetRowCellValue(e.RowHandle, "MrId"); // Replace "YourColumnName" with the actual column name

            if (editValue == null || editValue == DBNull.Value)
            {
                // Default value when nothing is selected
                MessageBox.Show("Please Select a valid Mr Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // User has selected an item, proceed with the original logic
                // Convert the editValue to the appropriate type
                selectedMRId = Convert.ToInt32(editValue);
            }

            // Update default values or perform additional logic based on the new values
            // You can customize this section to fit your specific requirements

            // Save changes to the database
            try
            {
                var poToUpdate = await _PoService.GetPoByIdAsync(newpoId);
                if (poToUpdate != null)
                {
                    // Update the corresponding entity in the database
                    poToUpdate.MrId = selectedMRId;
                    poToUpdate.PoName = newPoName;
                    poToUpdate.PoDescription = newPoDescription;
                    poToUpdate.EnteredDate = newEnteredDate;

                    // Save changes to the database
                    await _PoService.UpdatePoAsync(poToUpdate);

                    // Get the updated row handle
                    int updatedRowHandle = gridView.LocateByValue("PoId", newpoId);

                    // Set the focused row handle to the updated row
                    gridView.FocusedRowHandle = updatedRowHandle;

                    // If the updated row is the new row, focus on the next row
                    if (gridView.IsNewItemRow(updatedRowHandle))
                    {
                        gridView.FocusedRowHandle = updatedRowHandle + 1;
                        gridView.FocusedColumn = gridView.VisibleColumns[0];
                        gridView.ShowEditor();
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex, "Error saving data");
            }
        }

        private void HandleException(Exception ex, string message)
        {
            string errorMessage = message + ": " + ex.Message;

            if (ex.InnerException != null)
            {
                errorMessage += Environment.NewLine + "Inner Exception: " + ex.InnerException.Message;
            }

            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteSelectedRows()
        {
            //GridView gridView = gridView1;

            //if (gridView != null && gridView.SelectedRowsCount > 0)
            //{
            //    // Confirm deletion with a prompt for each selected row
            //    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (result == DialogResult.Yes)
            //    {
            //        // Iterate through all selected rows
            //        int[] selectedRows = gridView.GetSelectedRows();
            //        foreach (int selectedRowHandle in selectedRows)
            //        {
            //            // Get the corresponding Mr entity
            //            Po selectedPo = gridView.GetRow(selectedRowHandle) as Po;

            //            if (selectedPo != null)
            //            {
            //                // Remove the entity from the list
            //                _poList.Remove(selectedPo);
            //                try
            //                {
            //                    // Remove the entity from the database
            //                    _dbContextWithoutUnitOfWork.Pos.Remove(selectedPo);
            //                }
            //                catch
            //                {
            //                    // Handle exception as needed
            //                }
            //            }
            //        }

            //    // Save changes to the database
            //    _dbContextWithoutUnitOfWork.SaveChanges();

            //    // Refresh the BindingSource to reflect the changes
            //    poBindingSource.DataSource = _dbContextWithoutUnitOfWork.Pos.ToList();
            //    poBindingSource.ResetBindings(false);
            //    }
            //}
        }
    }
}
