using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using AWMS.dapper;
using AWMS.dto;
using AWMS.dapper.Repositories;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmPK : XtraForm
    {
        private readonly IPackageDapperRepository _packageDapperRepository;
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private BackgroundWorker backgroundWorker;
        private bool _isRowAdded;
        public frmPK(IPackageDapperRepository packageDapperRepository, IPackingListDapperRepository packingListDapperRepository)
        {
            InitializeComponent();
            this._packageDapperRepository = packageDapperRepository;
            this._packingListDapperRepository = packingListDapperRepository;
            LoadLookup();
        }
        private async void LoadLookup()
        {
            lookUpEditPl.Properties.DataSource=await _packingListDapperRepository.GetAllPlNameAsync();
        }
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle && _isRowAdded)
            {
                // Customize the appearance of the focused row (newly added row)
                e.Appearance.BackColor = Color.LightGreen; // Set your desired background color
            }
            else
            {
                // Reset the text underline for non-duplicate rows
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
            }
        }
        private void lookUpEditPl_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEditPl.BackColor = Color.White;
            int plid;
            if (lookUpEditPl.EditValue == null || string.IsNullOrWhiteSpace(lookUpEditPl.EditValue.ToString()))
            {
                return;
            }
            else
            {
                plid = Convert.ToInt32(lookUpEditPl.EditValue);
            }

            int lastPK = 1;//_unitOfWork.PackageRepository.GetLastPackage(plid);
            int CountPK = 1; //_unitOfWork.PackageRepository.GetPackageCount(plid);
            lblcount.Text = "Count Of PK : " + CountPK;
            lblLastPK.Text = "Last PK : " + lastPK;

            InitializeGrid();
        }
        private void InitializeGrid()
        {
            int plid;
            if (lookUpEditPl.EditValue == null || string.IsNullOrWhiteSpace(lookUpEditPl.EditValue.ToString()))
            {
                return;
            }
            else
            {
                plid = Convert.ToInt32(lookUpEditPl.EditValue);
            }
            //using (DatabaseContext dbContext = new DatabaseContext())
            //{
            //    IDapper dapper = new DapperService(dbContext);
            //    _pkList = dapper.GetPackageOfSelectedPlWithDapper(plid);
            //    packageBindingSource.DataSource = _pkList;
            //}
        }
        private async void btnAddPK_Click(object sender, EventArgs e)
        {
            if (lookUpEditPl.EditValue == null || string.IsNullOrWhiteSpace(lookUpEditPl.EditValue.ToString()))
            {
                MessageBox.Show("Warning: Please Select Packing List!", "NOT Selected Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEditPl.BackColor = Color.OrangeRed;
                lookUpEditPl.Focus();
                return;
            }

            //bool result =  txtPKNumberChange();
            bool result = await txtPKNumberChange();
            if (result == false)
            {
                return;
            }

            int plid = Convert.ToInt32(lookUpEditPl.EditValue);
            int Pk = Convert.ToInt32(txtPKNumber.Text);
            decimal NetWeight = string.IsNullOrWhiteSpace(txtNetWeight.Text) ? 0 : Convert.ToDecimal(txtNetWeight.Text);
            decimal GrossWeight = string.IsNullOrWhiteSpace(txtGrossWeight.Text) ? 0 : Convert.ToDecimal(txtGrossWeight.Text);
            string Volume = string.IsNullOrWhiteSpace(txtVolume.Text) ? null : txtVolume.Text.Trim();
            string descripPK = string.IsNullOrWhiteSpace(txtPkDescription.Text) ? null : txtPkDescription.Text.Trim();
            string RemarkPl = string.IsNullOrWhiteSpace(txtremark.Text) ? null : txtremark.Text.Trim();
            DateTime ArDate;
            if (ArrivalDate.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Warning: Please Enter Arrival Date!", "NOT Selected Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ArrivalDate.BackColor = Color.OrangeRed;
                ArrivalDate.Focus();
                return;
            }
            else
            {
                ArDate = ArrivalDate.DateTime;
            }
            //Package newpack = new Package
            //{
            //    PLId = plid,
            //    PK = Pk,
            //    NetW=NetWeight,
            //    GrossW=GrossWeight,
            //    Volume = Volume,
            //    Desciption = descripPK,
            //    Remark=RemarkPl,
            //    ArrivalDate=ArDate
            //};

            //btnAddPK.Enabled = false;

            //await UpdateProgressBarAsync();

            //bool isAdded = await AddPKRecordAsync(newpack);

            //btnAddPK.Enabled = true;

            //if (isAdded)
            //{
            //    XtraMessageBox.Show("PK record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    progressBarControl1.Position = 0;
            //    InitializeGrid();

            //    int newRowHandle = gridView1.GetRowHandle(gridView1.DataRowCount - 1);
            //    gridView1.FocusedRowHandle = newRowHandle;

            //    _isRowAdded = true;
            //    await Task.Delay(2000);
            //    ResetRowHighlighting();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Failed to add PK record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    progressBarControl1.Position = 0;

            //}
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBarControl1.Position = i;

                // Simulate a small delay without blocking the UI
                await Task.Delay(2); // Adjust the delay time if needed
            }
        }
        //private async Task<bool> AddPKRecordAsync(Package newpack)
        //{
        //    try
        //    {
        //        // Add the Mr record to the database asynchronously
        //        return await Task.Run(() => _unitOfWork.PackageRepository.AddPackage(newpack));
        //    }
        //    catch (Exception)
        //    {
        //        // Handle exception (log, throw, etc.)
        //        return false;
        //    }
        //}

        private async void txtPKNumber_Leave(object sender, EventArgs e)
        {
            await txtPKNumberChange(); //txtPKNumberChange();
        }

        private void txtPKNumber_EditValueChanged(object sender, EventArgs e)
        {
            txtPKNumber.BackColor = Color.GhostWhite;
        }
        private int duplicateRowHandle;
        private int FindRowHandleByPkId(int pkId)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (Convert.ToInt32(gridView1.GetRowCellValue(i, "PKID")) == pkId)
                {
                    return i;
                }
            }
            return GridControl.InvalidRowHandle;
        }

        private async Task<bool> txtPKNumberChange()
        {
            int plid = Convert.ToInt32(lookUpEditPl.EditValue);

            txtPKNumber.BackColor = Color.White;
            bool isNumeric = int.TryParse(txtPKNumber.Text, out int pkNumber);

            if (!isNumeric)
            {
                // Handle the case where the input is not a valid number
                MessageBox.Show("Invalid PK Number! Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPKNumber.BackColor = Color.OrangeRed;
                return false;
            }

            bool PkExist = false;// _unitOfWork.PackageRepository.CheckPkExist(plid, pkNumber);
            int pkId = 1;// _unitOfWork.PackageRepository.GetPkId(plid, pkNumber);

            if (PkExist)
            {
                MessageBox.Show("Duplicate PK Number found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPKNumber.BackColor = Color.OrangeRed;

                // Save the original appearance properties for the duplicate row
                Font originalFont = gridView1.Appearance.Row.Font.Clone() as Font;
                Color originalForeColor = gridView1.Appearance.Row.ForeColor;

                // Change the color of the duplicate row in the GridView using RowCellStyle event
                gridView1.RowCellStyle += RowCellStyleHandler;

                // Sort the grid by the column (replace "YourColumnName" with the actual column name)
                gridView1.ClearSorting();
                gridView1.ClearGrouping();
                gridView1.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] {
            new GridColumnSortInfo(gridView1.Columns["PKID"], ColumnSortOrder.Ascending)
        });

                // Find the row handle based on PKID
                int newFocusedRowHandle = FindRowHandleByPkId(pkId);

                // Focus on the duplicate row after sorting
                gridView1.FocusedRowHandle = newFocusedRowHandle;

                await Task.Delay(3000);

                // Reset the appearance of the duplicate row after the delay
                gridView1.RowCellStyle -= RowCellStyleHandler;
                return false;
            }

            return true;
        }

        private void RowCellStyleHandler(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LightSalmon; // Set your desired color for duplicate row
            }
        }


        private void ResetRowHighlighting()
        {
            // Reset the appearance of the new row and duplicate row
            _isRowAdded = false;
            // Reset the appearance of the entire grid
            gridView1.Appearance.FocusedRow.BackColor = Color.Empty;
            gridView1.Appearance.FocusedCell.ForeColor = Color.Empty;
            gridView1.Appearance.FocusedCell.BackColor = Color.Empty;
            gridView1.Appearance.FocusedCell.Font = new Font(gridView1.Appearance.FocusedCell.Font, FontStyle.Regular);

            // Force the grid to repaint
            gridView1.Invalidate();
        }
        private void ArrivalDate_EditValueChanged(object sender, EventArgs e)
        {
            ArrivalDate.BackColor = Color.White;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0) // Make sure it's a data row, not a new row or group row
            {
                int pkId = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "PKID"));

                // Assuming you have a method to update a package in the database
                //using (var dbContext = new DatabaseContext())
                //{
                //    var packageToUpdate = dbContext.Packages.Find(pkId);

                //    if (packageToUpdate != null)
                //    {
                //        // Iterate through all columns and update corresponding properties
                //        foreach (GridColumn col in gridView1.Columns)
                //        {
                //            if (col.FieldName != "PKID" && col.FieldName != "PLId" && col.FieldName != "EditedDate")
                //            {
                //                object cellValue = gridView1.GetRowCellValue(e.RowHandle, col);

                //                // Check if the cell value is not null
                //                if (cellValue != null)
                //                {
                //                    // Update the corresponding property of the Package entity
                //                    var property = packageToUpdate.GetType().GetProperty(col.FieldName);
                //                    if (property != null)
                //                    {
                //                        Type propertyType = property.PropertyType;
                //                        Type underlyingType = Nullable.GetUnderlyingType(propertyType);

                //                        if (underlyingType != null)
                //                        {
                //                            // Handle nullable properties
                //                            property.SetValue(packageToUpdate, Convert.ChangeType(cellValue, underlyingType));
                //                        }
                //                        else
                //                        {
                //                            // Handle non-nullable properties
                //                            property.SetValue(packageToUpdate, Convert.ChangeType(cellValue, propertyType));
                //                        }
                //                    }
                //                }
                //            }
                //        }

                //        // Save changes to the database
                //        dbContext.SaveChanges();
                //    }
                //} // The using statement ensures that dbContext is disposed when this block is exited
            }
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
        //private void barButtonItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (e.Item == barButtonItem1)
        //    {
        //        SaveGridData("PDF Files|*.pdf", "Save PDF File", fileName => gridView1.ExportToPdf(fileName));
        //    }
        //    else if (e.Item == barButtonItem2)
        //    {
        //        SaveGridData("Excel Files|*.xlsx", "Save Excel File", fileName => gridView1.ExportToXlsx(fileName));
        //    }
        //    else if (e.Item == barButtonItem3)
        //    {
        //        gridView1.Print();
        //    }
        //    else if (e.Item == barButtonItemDelete)
        //    {
        //        DeleteSelectedRows();
        //    }
        //}

        private void DeleteSelectedRows()
        {
            GridView gridView = gridView1;
            int plid;
            if (lookUpEditPl.EditValue == null || string.IsNullOrWhiteSpace(lookUpEditPl.EditValue.ToString()))
            {
                return;
            }
            else
            {
                plid = Convert.ToInt32(lookUpEditPl.EditValue);
            }
            if (gridView != null && gridView.SelectedRowsCount > 0)
            {
                // Confirm deletion with a prompt for each selected row
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //if (result == DialogResult.Yes)
                //{
                //    using (var dbContext = new DatabaseContext())
                //    {
                //        IDapper dapper = new DapperService(dbContext);
                //        // Iterate through all selected rows
                //        int[] selectedRows = gridView.GetSelectedRows();
                //        foreach (int selectedRowHandle in selectedRows)
                //        {

                //            // Get the corresponding Package entity
                //            Package selectedPackage = gridView.GetRow(selectedRowHandle) as Package;

                //            if (selectedPackage != null)
                //            {

                //                int PKID = selectedPackage.PKID;



                //                    dapper.deletePackageOfSelectedPlWithDapper(plid, PKID);

                //            }
                //        }

                //        // Refresh the grid after deletion
                //        InitializeGrid();
                //    }
                //}
            }
        }


        ////
    }
}
