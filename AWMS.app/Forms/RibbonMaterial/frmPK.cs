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
using AWMS.app.Utility;
using AWMS.core.Interfaces;
using AWMS.app.Forms.RibbonUser;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmPK : XtraForm
    {
        private readonly IPackageDapperRepository _packageDapperRepository;
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private readonly UserSession _session; // اضافه کردن UserSession
        private bool _isRowAdded;

        public frmPK(IPackageDapperRepository packageDapperRepository, IPackingListDapperRepository packingListDapperRepository,
            int userId)
        {
            InitializeComponent();
            this._packageDapperRepository = packageDapperRepository;
            this._packingListDapperRepository = packingListDapperRepository;
            _session = SessionManager.GetSession(userId); // گرفتن نشست کاربر بر اساس userId
            LoadLookup();
        }
        private async void LoadLookup()
        {
            lookUpEditPl.Properties.DataSource = await _packingListDapperRepository.GetAllPlNameAsync();
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

            LoadLabelData(plid);

            InitializeGrid();
        }

        private void LoadLabelData(int plid)
        {
            int lastPK = _packageDapperRepository.GetLastPackage(plid);
            int CountPK = _packageDapperRepository.GetPackageCount(plid);
            lblcount.Text = "Count Of PK : " + CountPK;
            lblLastPK.Text = "Last PK : " + lastPK;
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

            gridcontrol.DataSource = _packageDapperRepository.GetPackageByPLId(plid);

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
            var userId = _session.UserID; // گرفتن UserID از نشست کاربر

            var newpack = new PackageDto()
            {
                PLId = plid,
                PK = Pk,
                NetW = NetWeight,
                GrossW = GrossWeight,
                Volume = Volume,
                Desciption = descripPK,
                Remark = RemarkPl,
                ArrivalDate = ArDate,
                EnteredBy = userId, // اضافه کردن UserID به فیلد EditedBy
                EnteredDate=DateTime.Now
            };


            btnAddPK.Enabled = false;

            await UpdateProgressBarAsync();

            bool isAdded = _packageDapperRepository.AddPackage(newpack);

            btnAddPK.Enabled = true;

            if (isAdded)
            {
                //XtraMessageBox.Show("PK record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBarControl1.Position = 0;
                InitializeGrid();
                LoadLabelData(plid);

                int newRowHandle = gridView1.GetRowHandle(gridView1.DataRowCount - 1);
                gridView1.FocusedRowHandle = newRowHandle;

                _isRowAdded = true;
                await Task.Delay(2000);
                ResetRowHighlighting();
            }
            else
            {
                XtraMessageBox.Show("Failed to add PK record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;

            }
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i += 5)
            {
                progressBarControl1.Position = i;

                //Simulate a small delay without blocking the UI
                await Task.Delay(10); // Adjust the delay time if needed
            }
        }

        private async void txtPKNumber_Leave(object sender, EventArgs e)
        {
            await txtPKNumberChange(); //txtPKNumberChange();
        }

        private void txtPKNumber_EditValueChanged(object sender, EventArgs e)
        {
            txtPKNumber.BackColor = Color.GhostWhite;
        }

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

            bool PkExist = _packageDapperRepository.CheckPkExist(plid, pkNumber);
            int pkId = _packageDapperRepository.GetPkId(plid, pkNumber);

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
            // Get the changed value
            var newValue = e.Value;

            // Get the current row handle
            int rowHandle = e.RowHandle;

            // Get the column name
            string columnName = e.Column.FieldName;

            // Get the PKID of the current row
            int pkId = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "PKID"));

            // Update the corresponding property in the data source
            var package = (PackageDto)gridView1.GetRow(rowHandle);
            package.EditedBy = _session.UserID; // تنظیم شناسه کاربر ویرایش‌کننده
            package.EditedDate = DateTime.Now; // تنظیم تاریخ و زمان فعلی
            switch (columnName)
            {
                case "PK":
                    package.PK = Convert.ToInt32(newValue);
                    break;
                case "PLId":
                    package.PLId = Convert.ToInt32(newValue);
                    break;
                case "NetW":
                    package.NetW = Convert.ToDecimal(newValue);
                    break;
                case "GrossW":
                    package.GrossW = Convert.ToDecimal(newValue);
                    break;
                case "Dimension":
                    package.Dimension = newValue.ToString();
                    break;
                case "Volume":
                    package.Volume = newValue.ToString();
                    break;
                case "ArrivalDate":
                    package.ArrivalDate = Convert.ToDateTime(newValue);
                    break;
                case "Desciption":
                    package.Desciption = newValue.ToString();
                    break;
                case "Remark":
                    package.Remark = newValue.ToString();
                    break;
                case "EnteredDate":
                    package.EnteredDate = Convert.ToDateTime(newValue);
                    break;
                case "MSRNO":
                    package.MSRNO = newValue.ToString();
                    break;
                case "MSRPDF":
                    package.MSRPDF = newValue.ToString();
                    break;
                case "MSRDate":
                    package.MSRDate = Convert.ToDateTime(newValue);
                    break;
                case "MSRRevDate":
                    package.MSRRevDate = Convert.ToDateTime(newValue);
                    break;
                default:
                    // Handle any other columns or log an error if needed
                    break;
            }

            // Update the database
            bool isUpdated = _packageDapperRepository.UpdatePackage(pkId, package);

            // Show a message based on the update result
            if (isUpdated)
            {
                XtraMessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Column.AppearanceCell.BackColor = Color.LightGreen; // Change the cell background color to light green
            }
            else
            {
                XtraMessageBox.Show("Failed to update the record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Column.AppearanceCell.BackColor = Color.OrangeRed; // Change the cell background color to orange red
            }

            // Force the grid to repaint to reflect the changes
            gridView1.RefreshRow(rowHandle);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "PkExcelOutPut.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportFromGridViewDevexpress.ExportToExcel(gridView1, sfd.FileName); // فرض می‌کنیم gridView1 نام GridView DevExpress شماست
                }
            }
        }

        private async void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           await DeleteSelectedRows();
        }
        private async Task DeleteSelectedRows()
        {
            GridView gridView = gridView1;

            if (gridView != null && gridView.SelectedRowsCount > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    List<PackagePKIDDto> selectedPKIDs = new List<PackagePKIDDto>();

                    // Get the selected rows directly from gridView
                    foreach (int rowHandle in gridView.GetSelectedRows())
                    {
                        if (gridView.GetRow(rowHandle) is PackageDto selectedPackage)
                        {
                            selectedPKIDs.Add(new PackagePKIDDto { PKID = selectedPackage.PKID });
                        }
                    }

                    try
                    {
                        await _packageDapperRepository.DeleteMultiplePKsWithTransactionAsync(selectedPKIDs);
                        InitializeGrid(); // Reload data into the grid after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete selected items. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



    }
}
