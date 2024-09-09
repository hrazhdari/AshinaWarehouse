using AWMS.core.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWMS.datalayer.Repositories;
using AWMS.app.Forms.RibbonUser;
using AWMS.dto;
using DevExpress.XtraCharts.Design;
using AWMS.datalayer.Entities;
using AWMS.app.Utility;

namespace AWMS.app.Forms
{
    public partial class frmCompanyContract : XtraForm
    {
        private readonly ICompanyService _CompanyService;
        private readonly IContractService _CompanyContactService;
        private readonly UserSession _session; // اضافه کردن UserSession


        private int _highlightedRowHandle = GridControl.InvalidRowHandle;
        public frmCompanyContract(ICompanyService companyService , IContractService companyContract, int? UserId = null)
        {
            InitializeComponent();
            this._CompanyService = companyService;
            this._CompanyContactService = companyContract;
            // اگر UserId پاس داده نشده بود، مقدار پیش‌فرض 1 استفاده می‌شود
            int finalUserId = UserId ?? 1;
            _session = SessionManager.GetSession(finalUserId);

            labelControl4.Text = DateTime.Now.ToString();

            // متدها را به صورت async و مستقل اجرا کنید
            InitializeGrid();
            LoadData();
            LoadGrid();
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

        private async void LoadGrid()
        {
            try
            {
                // Await the asynchronous operation
                var Contracts = await _CompanyContactService.GetAllContractsAsync();
                gridcontrol.DataSource = Contracts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                // دریافت داده‌ها
                var Comapny = _CompanyService.GetAllCompanies();

                // تنظیم منبع داده برای لوکاپ‌ها
                lookUpEditCompany.Properties.DataSource = Comapny;
                repositoryItemLookUpEdit1.DataSource = Comapny;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void frmCompanyContract_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddContract_Click(object sender, EventArgs e)
        {

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 12;

            string ContractNumber = txtContractNumber.Text.Trim();
            string ContractDescription = txtContractDescription.Text.Trim();
            string ContractRemark = txtContractRemark.Text.Trim();
            var selectedCompanyId = 0;
            DateTime enteredDate = enteredDateContract.DateTime != DateTime.MinValue ? enteredDateContract.DateTime : DateTime.Now;

            if (lookUpEditCompany.EditValue == null || lookUpEditCompany.EditValue == DBNull.Value)
            {
                // Default value when nothing is selected
                MessageBox.Show("Please Select a valid Company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // User has selected an item, proceed with the original logic
                selectedCompanyId = Convert.ToInt32(lookUpEditCompany.EditValue);
            }

            if (string.IsNullOrWhiteSpace(ContractNumber))
            {
                MessageBox.Show("Please enter a valid Contract Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                int? duplicateRowHandleNullable = await _CompanyContactService.GetByContractNumberAsync(ContractNumber);
                if (duplicateRowHandleNullable.HasValue)
                {
                    int duplicateRowHandle = gridView1.LocateByValue("ContractNumber", ContractNumber);

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

            var newContract = new CompanyContract()
            {
                ContractNumber = ContractNumber,
                CompanyID = selectedCompanyId,
                ContractDescription = ContractDescription,
                ContractRemark = ContractRemark,
                EnteredBy = _session.UserID,
                EnteredDate = enteredDate
            };

            btnAddContract.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await AddContractRecordAsync(newContract);

            btnAddContract.Enabled = true;

            if (isAdded > 0)
            {
                progressBarControl1.Position = 0;

                LoadGrid();

                // Get the handle of the newly added row
                int newRowHandle = gridView1.LocateByValue("ContractId", isAdded);

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
        private async Task<int> AddContractRecordAsync(CompanyContract companyContract)
        {
            try
            {
                // Add the Contract record to the database asynchronously
                return await Task.Run(() => _CompanyContactService.AddCompanyContractAsync(companyContract));
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
            int ContractId = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ContractId"));
            string ContractNumber = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "ContractNumber")).Trim();
            string ContractDescription = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "ContractDescription")).Trim();
            string ContractRemark = Convert.ToString(gridView.GetRowCellValue(e.RowHandle, "ContractRemark")).Trim();
            //DateTime newEnteredDate = Convert.ToDateTime(gridView.GetRowCellValue(e.RowHandle, "EnteredDate"));
            var CompanyID = 0;

            // Retrieve the selected value from repositoryItemLookUpEdit1
            var editValue = gridView.GetRowCellValue(e.RowHandle, "CompanyID"); // Replace "YourColumnName" with the actual column name

            if (editValue == null || editValue == DBNull.Value)
            {
                // Default value when nothing is selected
                MessageBox.Show("Please Select a valid Company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // User has selected an item, proceed with the original logic
                // Convert the editValue to the appropriate type
                CompanyID = Convert.ToInt32(editValue);
            }

            // Update default values or perform additional logic based on the new values
            // You can customize this section to fit your specific requirements

            // Save changes to the database
            try
            {
                var contractToUpdate = _CompanyContactService.GetContractByIdAsync(ContractId);
                if (contractToUpdate != null)
                {
                    // Update the corresponding entity in the database
                    contractToUpdate.CompanyID = CompanyID;
                    contractToUpdate.ContractNumber = ContractNumber;
                    contractToUpdate.ContractDescription = ContractDescription;
                    contractToUpdate.ContractRemark = ContractRemark;
                    contractToUpdate.EditedBy = _session.UserID;
                    contractToUpdate.EditedDate = DateTime.Now;

                    // Save changes to the database
                    await _CompanyContactService.UpdateCompanyContractAsync(contractToUpdate);

                    // Get the updated row handle
                    int updatedRowHandle = gridView.LocateByValue("ContractId", ContractId);

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
        private async Task DeleteSelectedRows()
        {
            GridView gridView = gridView1;

            if (gridView != null && gridView.SelectedRowsCount > 0)
            {
                // Confirm deletion with a prompt for each selected row
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Initialize a list to hold IDs of selected items to delete
                    List<CompanyContract> selectedContracts = new List<CompanyContract>();

                    // Iterate through all selected rows
                    int[] selectedRows = gridView.GetSelectedRows();
                    foreach (int selectedRowHandle in selectedRows)
                    {
                        // Get the corresponding Po entity
                        CompanyContract selectedContract = gridView.GetRow(selectedRowHandle) as CompanyContract;
                        if (selectedContract != null)
                        {
                            selectedContracts.Add(selectedContract);
                        }
                    }

                    // Delete selected Contract entities using a transaction
                    try
                    {
                        await _CompanyContactService.DeleteMultipleContractsWithTransactionAsync(selectedContracts);

                        // If deletion is successful, refresh the grid
                        LoadGrid(); // Assuming this method reloads data into the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete selected items. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteSelectedRows();
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportFromGridViewDevexpress.SaveGridData("Excel Files|*.xlsx", "Save Excel File", fileName => gridView1.ExportToXlsx(fileName));
        }
    }
}
