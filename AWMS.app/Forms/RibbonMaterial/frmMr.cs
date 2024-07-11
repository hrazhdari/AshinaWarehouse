using DevExpress.Data;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AWMS.core.Interfaces;
using AWMS.core;
using AWMS.app.Utility;
using AWMS.dto;
using DevExpress.XtraGrid;
using OfficeOpenXml.Style;
using OfficeOpenXml;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmMr : XtraForm
    {
        private readonly IMrService _MrService;
        private int _highlightedRowHandle = GridControl.InvalidRowHandle;
        public frmMr(IMrService MrService)
        {
            InitializeComponent();
            this._MrService = MrService;
            lblMrEnterDate.Text = DateTime.Now.ToString();

            LoadData();
            InitializeGrid();
        }

        #region Initial and Load
        private async void LoadData()
        {
            try
            {
                // تغییر نشانگر موس به حالت لودینگ
                Cursor.Current = Cursors.WaitCursor;

                // بارگذاری داده‌ها
                var Mrs = await _MrService.GetAllMrsAsync();

                // تنظیم داده‌ها به DataGridView
                gridControl1.DataSource = Mrs;
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

        private void InitializeGrid()
        {
            GridView gridView = gridView1;

            if (gridView != null)
            {
                // Enable multi-row selection
                gridView.OptionsSelection.MultiSelect = true;
                gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

                gridView.CellValueChanged += GridView_CellValueChanged; // Handle the CellValueChanged event
            }
        }

        #endregion
        #region Add Mr
        private async void btnAddMr_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 12;

            string mrName = txtMrName.Text.Trim();
            string mrDescription = txtMrDescription.Text.Trim();
            DateTime enteredDate = dateEdit1.DateTime != DateTime.MinValue ? dateEdit1.DateTime : DateTime.Now;

            if (string.IsNullOrWhiteSpace(mrName))
            {
                MessageBox.Show("Please enter a valid Mr Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the Mr name is unique
            var uniqueNameCheck = await _MrService.GetByMrNameAsync(mrName);
            if (uniqueNameCheck != null)
            {
                int duplicateRowHandle = gridView1.LocateByValue("MrName", mrName);

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

            var newMr = new MrDto()
            {
                MrName = mrName,
                MrDescription = mrDescription,
                EnteredDate = enteredDate
            };

            btnAddMr.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await AddMrRecordAsync(newMr);

            btnAddMr.Enabled = true;

            if (isAdded > 0)
            {
                progressBarControl1.Position = 0;

                // Reload data and initialize the grid
                LoadData();

                // Add a small delay to ensure the data is loaded
                await Task.Delay(500);

                //// Make sure the data is properly loaded before getting the row handle
                //gridView1.RefreshData();

                // Get the handle of the newly added row
                int newRowHandle = gridView1.LocateByValue("MrId", isAdded);

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
                XtraMessageBox.Show("Failed to add Mr record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private async Task<int> AddMrRecordAsync(MrDto newMr)
        {
            try
            {
                // Add the Mr record to the database asynchronously
                var newCompanyId = await _MrService.AddMrAsync(newMr);
                return newCompanyId;
            }
            catch (Exception)
            {
                // Handle exception (log, throw, etc.)
                return -1;
            }
        }
        #endregion
        #region Edit Mr
        private async void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = sender as GridView;

            // Get the new values
            int newMrId = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "MrId"));
            string newMrName = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "MrName")).Trim();
            string newMrDescription = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "MrDescription")).Trim();
            DateTime newEnteredDate = Convert.ToDateTime(gridView.GetRowCellValue(e.RowHandle, "EnteredDate"));

            // Save changes to the database
            try
            {
                var mrToUpdate = await _MrService.GetMrByIdAsync(newMrId);
                if (mrToUpdate != null)
                {
                    // Update the corresponding entity in the database
                    mrToUpdate.MrName = newMrName;
                    mrToUpdate.MrDescription = newMrDescription;
                    mrToUpdate.EnteredDate = newEnteredDate;

                    // Save changes to the database
                    await _MrService.UpdateMrAsync(mrToUpdate);

                    // Get the updated row handle
                    int updatedRowHandle = gridView.LocateByValue("MrId", newMrId);

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
        #endregion
        #region Delete Mr
        private async void DeleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = gridView1;

            if (gridView != null && gridView.SelectedRowsCount > 0)
            {
                // Confirm deletion with a prompt for each selected row
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Initialize a list to hold IDs of selected items to delete
                    List<MrDto> selectedMrs = new List<MrDto>();

                    // Iterate through all selected rows
                    int[] selectedRows = gridView.GetSelectedRows();
                    foreach (int selectedRowHandle in selectedRows)
                    {
                        // Get the corresponding Mr entity
                        MrDto selectedMr = gridView.GetRow(selectedRowHandle) as MrDto;
                        if (selectedMr != null)
                        {
                            selectedMrs.Add(selectedMr);
                        }
                    }

                    // Delete selected Mr entities using a transaction
                    try
                    {
                        await _MrService.DeleteMultipleMrsWithTransactionAsync(selectedMrs);

                        // If deletion is successful, refresh the grid
                        LoadData(); // Assuming this method reloads data into the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete selected items. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
        #region ExcelRport
        private void ExcelExportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "output.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportFromGridViewDevexpress.ExportToExcel(gridView1, sfd.FileName); // فرض می‌کنیم gridView1 نام GridView DevExpress شماست
                }
            }
        }
        #endregion
    }
}
