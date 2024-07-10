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
    public partial class frmPo : frmBase.frmBase
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

            LoadData();
            InitializeGrid();
        }
        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //if (e.RowHandle == gridView1.FocusedRowHandle && _isRowAdded)
            //{
            //    // Customize the appearance of the focused row (newly added row)
            //    e.Appearance.BackColor = Color.LightGreen; // Set your desired background color
            //}
            //else
            //{
            //    // Reset the text underline for non-duplicate rows
            //    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
            //}
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
                    int duplicateRowHandle = duplicateRowHandleNullable.Value;
                    MessageBox.Show("Po Name already exists. Please enter a unique Po Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Save the original appearance properties for the duplicate row
                    Font originalFont = gridView1.Appearance.Row.Font.Clone() as Font;
                    Color originalForeColor = gridView1.Appearance.Row.ForeColor;

                    // Change the color of the duplicate row in the GridView using RowCellStyle event
                    gridView1.RowCellStyle += (s, args) =>
                    {
                        if (args.RowHandle == duplicateRowHandle)
                        {
                            args.Appearance.BackColor = Color.LightSalmon; // Set your desired color for duplicate row
                        }
                    };

                    // Sort the grid by the column (replace "YourColumnName" with the actual column name)
                    gridView1.ClearSorting();
                    gridView1.ClearGrouping();
                    gridView1.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] {
                    new GridColumnSortInfo(gridView1.Columns["PoId"], ColumnSortOrder.Ascending)
                });

                    // Focus on the duplicate row after sorting
                    gridView1.FocusedRowHandle = duplicateRowHandle;

                    await Task.Delay(3000);

                    // Reset the appearance of the duplicate row after the delay
                    gridView1.RowCellStyle += (s, args) =>
                    {
                        if (args.RowHandle == duplicateRowHandle)
                        {
                            args.Appearance.BackColor = originalForeColor;
                            args.Appearance.ForeColor = originalForeColor;
                            args.Appearance.Font = originalFont;
                        }
                    };
                    return;
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

            if (isAdded>0)
            {
                XtraMessageBox.Show("Po record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;

                LoadData();
                InitializeGrid();

                int newRowHandle = gridView1.GetRowHandle(gridView1.DataRowCount - 1);
                gridView1.FocusedRowHandle = newRowHandle;

                await Task.Delay(3000);
                ResetRowHighlighting();
            }
            else
            {
                XtraMessageBox.Show("Failed to add Po record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;
            }
        }

        private void ResetRowHighlighting()
        {
            // Reset the appearance of the new row and duplicate row
            
            // Reset the appearance of the entire grid
            gridView1.Appearance.FocusedRow.BackColor = Color.Empty;
            gridView1.Appearance.FocusedCell.ForeColor = Color.Empty;
            gridView1.Appearance.FocusedCell.BackColor = Color.Empty;
            gridView1.Appearance.FocusedCell.Font = new Font(gridView1.Appearance.FocusedCell.Font, FontStyle.Regular);

            // Force the grid to repaint
            gridView1.Invalidate();
        }

        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i++)
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

        private async void LoadData()
        {
            try
            {
                // تغییر نشانگر موس به حالت لودینگ
                Cursor.Current = Cursors.WaitCursor;

                // بارگذاری داده‌ها
                var Mrs = await _MrService.GetMrIdAndNameAsync();

                lookUpEdit1.Properties.DataSource = Mrs;
                //repositoryItemLookUpEdit1.DataSource = _mrList;
            }
            catch (Exception ex)
            {
                // مدیریت خطاها
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // بازگرداندن نشانگر موس به حالت پیش‌فرض
                Cursor.Current = Cursors.Default;
            }
        }
        //private List<Po> GetListOfPosFromDatabase()
        //{
        //    // Replace this with your actual data retrieval logic from the database
        //    // For now, returning a dummy list
        //    return _dbContextWithoutUnitOfWork.Pos.ToList();
        //}
        //private List<Mr> GetListOfMrsFromDatabase()
        //{
        //    // Replace this with your actual data retrieval logic from the database
        //    // For now, returning a dummy list
        //    return _dbContextWithoutUnitOfWork.Mrs.ToList();
        //}

        private void InitializeGrid()
        {
            GridView gridView = gridView1;

            if (gridView != null)
            {
                // Enable multi-row selection
                gridView.OptionsSelection.MultiSelect = true;
                gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

                gridView.CellValueChanged += GridView_CellValueChanged; // Handle the CellValueChanged event
                // Set the data source for the grid
                //poBindingSource.DataSource = _poList;
                //gridControl1.DataSource = poBindingSource;

            }
        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //// Handle cell value changes for any column
            //GridView gridView = sender as GridView;

            //// Get the new values
            //string newpoName = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "PoName"));
            //string newpoDescription = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "PoDescription"));

            //// Update default values or perform additional logic based on the new values
            //// You can customize this section to fit your specific requirements

            //// Save changes to the database
            //try
            //{
            //    // Assuming you have an instance of your DbContext named dbContextWithoutUnitOfWork
            //    int poId = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "PoId"));
            //    var poToUpdate = _dbContextWithoutUnitOfWork.Pos.FirstOrDefault(po => po.PoId == poId);

            //    if (poToUpdate != null)
            //    {
            //        // Update the corresponding entity in the dbContextWithoutUnitOfWork
            //        poToUpdate.PoName = newpoName;
            //        poToUpdate.PoDescription = newpoDescription;

            //        // Save changes to the database
            //        _dbContextWithoutUnitOfWork.SaveChanges();

            //        // Get the updated row handle
            //        int updatedRowHandle = gridView.GetRowHandle(_poList.IndexOf(poToUpdate));

            //        // Set the focused row handle to the updated row
            //        gridView.FocusedRowHandle = updatedRowHandle;

            //        // If the updated row is the new row, focus on the next row
            //        if (gridView.IsNewItemRow(updatedRowHandle))
            //        {
            //            gridView.FocusedRowHandle = updatedRowHandle + 1;
            //            gridView.FocusedColumn = gridView.VisibleColumns[0];
            //            gridView.ShowEditor();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    HandleException(ex, "Error saving data");
            //}
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

        private void SaveGridData(string filter, string title, Action<string> exportAction)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportAction.Invoke(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show($"{Path.GetExtension(saveFileDialog.FileName)} file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void frmPo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_unitOfWork.Dispose();
            //_dbContextWithoutUnitOfWork.Dispose();
        }
    }
}
