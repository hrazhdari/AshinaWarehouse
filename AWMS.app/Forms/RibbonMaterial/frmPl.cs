using AWMS.app.Forms.RibbonUser;
using AWMS.core.Interfaces;
using AWMS.dapper;
using AWMS.dapper.Repositories;
using AWMS.dto;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraReports.Parameters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmPl : XtraForm
    {
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDescriptionForPkService _descriptionForPkService;
        private readonly IIrnService _irnService;
        private readonly IShipmentService _shipmentService;
        private readonly IAreaUnitService _areaUnitService;
        private readonly ISupplierService _supplierService;
        private readonly IVendorService _vendorService;
        private readonly IDesciplineService _desciplineService;
        private readonly IMrService _mrService;
        private readonly IPoService _poService;
        private readonly UserSession _session; // اضافه کردن UserSession
        public frmPl(IPackingListDapperRepository PackingListDapperRepository, IServiceProvider serviceProvider,
            IDescriptionForPkService descriptionForPkService,
            IIrnService irnService, IShipmentService shipmentService, IAreaUnitService areaUnitService,
            IVendorService vendorService, ISupplierService supplierService, IDesciplineService desciplineService,
            IMrService mrService, IPoService poService, int userId)
        {
            InitializeComponent();
            _packingListDapperRepository = PackingListDapperRepository;
            lblEnteredPlDate.Text = DateTime.Now.ToString();
            _serviceProvider = serviceProvider;

            this._descriptionForPkService = descriptionForPkService;
            this._irnService = irnService;
            this._shipmentService = shipmentService;
            this._areaUnitService = areaUnitService;
            this._supplierService = supplierService;
            this._vendorService = vendorService;
            this._desciplineService = desciplineService;
            this._mrService = mrService;
            this._poService = poService;
            _session = SessionManager.GetSession(userId); // گرفتن نشست کاربر بر اساس userId

            LoadLookUps();
        }
        #region showing load panel in main form
        public void InitializeAndShow()
        {
            // Your initialization logic here

            // Show the form on the main UI thread
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Show();
                }));
            }
            else
            {
                this.Show();
            }
        }
        #endregion
        private void LoadLookUps()
        {
            DesRecordAddedHandler(this,EventArgs.Empty);
            IRNRecordAddedHandler(this, EventArgs.Empty);
            ShipRecordAddedHandler(this, EventArgs.Empty);
            RefreshMr_Click(this, EventArgs.Empty);
            RefreshPO_Click(this, EventArgs.Empty);
            areaRecordAddedHandler(this, EventArgs.Empty);
            supplierRecordAddedHandler(this, EventArgs.Empty);
            vendorRecordAddedHandler(this, EventArgs.Empty);
            lookUpEditDescipline.Properties.DataSource = _desciplineService.GetAllDesciplines();
        }
        private async void txtPlNumber_Leave(object sender, EventArgs e)
        {
            string plNo = txtPlNumber.Text.Trim();
            if (string.IsNullOrEmpty(plNo))
            {
                return;
            }

            bool isDuplicate = await IsDuplicatePLNO(plNo);
            if (isDuplicate)
            {
                MessageBox.Show("Warning: Duplicate PL Number found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDuplicate.Text = "Duplicate !";
                lblDuplicate.ForeColor = Color.Red;
                txtPlNumber.BackColor = Color.OrangeRed;
            }
            else
            {
                lblDuplicate.Text = "Not Duplicate";
                lblDuplicate.ForeColor = Color.Green;
                txtPlNumber.BackColor = Color.White;
            }
        }
        private async Task<bool> IsDuplicatePLNO(string plNo)
        {
            try
            {
                return await _packingListDapperRepository.ExistsByPlNoAsync(plNo);
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine($"Exception in IsDuplicatePLNO: {ex.Message}");
                return false; // Return false in case of exception
            }
        }
        private async void txtplName_Leave(object sender, EventArgs e)
        {
            string plName = txtplName.Text.Trim();
            if (string.IsNullOrEmpty(plName))
            {
                return;
            }

            try
            {
                bool isDuplicate = await IsDuplicatePLName(plName);

                if (isDuplicate)
                {
                    MessageBox.Show("Warning: Duplicate PL Name found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblduplicateplname.Text = "Duplicate !";
                    lblduplicateplname.ForeColor = Color.Red;
                    txtplName.BackColor = Color.OrangeRed;
                }
                else
                {
                    lblduplicateplname.Text = "Not Duplicate";
                    lblduplicateplname.ForeColor = Color.Green;
                    txtplName.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine($"Exception in txtplName_Leave: {ex.Message}");
                MessageBox.Show("An error occurred while checking the PL Name. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> IsDuplicatePLName(string plName)
        {
            try
            {
                return await _packingListDapperRepository.ExistsByPlNameAsync(plName);
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine($"Exception in IsDuplicatePLName: {ex.Message}");
                return false; // Return false in case of exception
            }
        }
        private void btnAddIrn_Click(object sender, EventArgs e)
        {
            //When I Don't Want Refresh Any Data
            //frmIRN frmirn = new frmIRN(attachEventHandler: false);

            var frmirn = _serviceProvider.GetRequiredService<Forms.frmSmall.frmIRN>();
            frmirn.IRNRecordAdded += IRNRecordAddedHandler;
            frmirn.ShowDialog();
        }
        private void IRNRecordAddedHandler(object? sender, EventArgs e)
        {
            lookUpEditIRN.Properties.DataSource = _irnService.GetAllIrns(); ;
        }
        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            var frmship = _serviceProvider.GetRequiredService<Forms.frmSmall.frmShipment>();
            frmship.ShipRecordAdded += ShipRecordAddedHandler;
            frmship.ShowDialog();
        }
        private void ShipRecordAddedHandler(object? sender, EventArgs e)
        {
            LookupShipment.Properties.DataSource = _shipmentService.GetAllShipments(); ;
        }
        private void RefreshMr_Click(object sender, EventArgs e)
        {
            lookUpEditMr.Properties.DataSource = _mrService.GetMrIdAndName();
        }
        private void RefreshPO_Click(object sender, EventArgs e)
        {
            lookUpEditPo.Properties.DataSource = _poService.GetPoIdAndName();
        }
        private void btnInsertArea_Click(object sender, EventArgs e)
        {
            var frmarea = _serviceProvider.GetRequiredService<Forms.frmSmall.frmAreaUnit>();
            frmarea.AreaRecordAdded += areaRecordAddedHandler;
            frmarea.ShowDialog();
        }
        private void areaRecordAddedHandler(object? sender, EventArgs e)
        {
            lookUpEditAreaUnit.Properties.DataSource = _areaUnitService.GetAllAreaUnits();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var frmsupplier = _serviceProvider.GetRequiredService<Forms.frmSmall.frmSupplier>();
            frmsupplier.SupplierRecordAdded += supplierRecordAddedHandler;
            frmsupplier.ShowDialog();
        }
        private void supplierRecordAddedHandler(object? sender, EventArgs e)
        {
            lookUpEditSupplier.Properties.DataSource = _supplierService.GetAllSuppliers();
        }
        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            var frmvendor = _serviceProvider.GetRequiredService<Forms.frmSmall.frmVendor>();
            frmvendor.VendorRecordAdded += vendorRecordAddedHandler;
            frmvendor.ShowDialog();
        }
        private void vendorRecordAddedHandler(object? sender, EventArgs e)
        {
            lookUpEditVendor.Properties.DataSource = _vendorService.GetAllVendors();
        }
        private void txtOpiNumber_Leave(object sender, EventArgs e)
        {
            string OpiNumber = txtOpiNumber.Text.Trim();
            if (string.IsNullOrEmpty(OpiNumber))
            {
                return;
            }

            try
            {
                bool isDuplicate = IsDuplicateOpiNumber(OpiNumber);

                if (isDuplicate)
                {
                    MessageBox.Show("Warning: Duplicate OpiNumber found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblDuplicateOpi.Text = "It's Duplicate But You Can Continue";
                    lblDuplicateOpi.ForeColor = Color.Coral;
                    txtOpiNumber.BackColor = Color.Bisque;
                }
                else
                {
                    lblDuplicateOpi.Text = "Not Duplicate";
                    lblDuplicateOpi.ForeColor = Color.Green;
                    txtOpiNumber.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine($"Exception in txtOpiNumber_Leave: {ex.Message}");
                MessageBox.Show("An error occurred while checking the OpiNumber. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDuplicateOpiNumber(string OpiNumber)
        {
            try
            {
                return  _packingListDapperRepository.ExistsByOpiNumber(OpiNumber);
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine($"Exception in IsDuplicateOpiNumber: {ex.Message}");
                return false; // Return false in case of exception
            }
        }

        private async void btnAddPl_Click(object sender, EventArgs e)
        {
            if (lblDuplicate.Text == "Duplicate !")
            {
                MessageBox.Show("Warning: Duplicate PL Number found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDuplicate.Text = "Duplicate !";
                lblDuplicate.ForeColor = Color.Red;
                txtPlNumber.BackColor = Color.OrangeRed;
                txtPlNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtplName.Text))
            {
                MessageBox.Show("Warning: Please Enter PL Name!", "Not Entered PL Name Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblduplicateplname.Text = "Please Enter PL Name!";
                lblduplicateplname.ForeColor = Color.Coral;
                txtplName.BackColor = Color.OrangeRed;
                txtplName.Focus();
                return;
            }

            if (lblduplicateplname.Text == "Duplicate !")
            {
                MessageBox.Show("Warning: Duplicate PL Name found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblduplicateplname.Text = "Duplicate !";
                lblduplicateplname.ForeColor = Color.Red;
                txtplName.BackColor = Color.OrangeRed;
                txtplName.Focus();
                return;
            }

            try
            {
                var newPackingList = new PackingListDto()
                {
                    ArchiveNO = string.IsNullOrWhiteSpace(txtPlNumber.Text) ? null : txtPlNumber.Text.Trim(),
                    PLNO = txtPlNumber.Text.Trim(),
                    OPINO = txtOpiNumber.Text.Trim(),
                    InvoiceNO = txtinvoicenumber.Text.Trim(),
                    PLName = txtplName.Text.Trim(),
                    DescriptionForPkId = Convert.ToInt32(lookUpEditDescription.EditValue ?? 1),
                    IrnId = Convert.ToInt32(lookUpEditIRN.EditValue ?? 1),
                    ShId = Convert.ToInt32(LookupShipment.EditValue ?? 1),
                    MrId = Convert.ToInt32(lookUpEditMr.EditValue ?? 1),
                    PoId = Convert.ToInt32(lookUpEditPo.EditValue ?? 1),
                    AreaUnitID = Convert.ToInt32(lookUpEditAreaUnit.EditValue ?? 1),
                    SupplierId = Convert.ToInt32(lookUpEditSupplier.EditValue ?? 1),
                    VendorId = Convert.ToInt32(lookUpEditVendor.EditValue ?? 1),
                    LocalForeign = radioGroup1.SelectedIndex != -1 ? radioGroup1.SelectedIndex + 1 : 1,
                    Vessel = txtVessel.Text.Trim(),
                    DesciplineId = Convert.ToInt32(lookUpEditDescipline.EditValue ?? 1),
                    NetW = string.IsNullOrWhiteSpace(txtNetWeight.Text) ? 0 : Convert.ToDecimal(txtNetWeight.Text),
                    GrossW = string.IsNullOrWhiteSpace(txtGrossWeight.Text) ? 0 : Convert.ToDecimal(txtGrossWeight.Text),
                    Volume = txtVolume.Text.Trim(),
                    Remark = txtRemarkPl.Text.Trim(),
                    MARDate = MARPLDate.DateTime != DateTime.MinValue ? MARPLDate.DateTime : DateTime.Now,
                    Project = txtProject.Text.Trim(),
                    RTINO = txtRTINumber.Text.Trim(),
                    IRCNO = txtIRCNumber.Text.Trim(),
                    LCNO = txtlcNumber.Text.Trim(),
                    BLNO = txtBLNumber.Text.Trim(),
                    Remarkcustoms = txtRemarkCustom.Text.Trim(),
                    EnteredBy=  _session.UserID,
                    EnteredDate=DateTime.Now,
                    SitePL = chkSite.Checked,
                    Balance = chkBalance.Checked
                };

                btnAddPl.Enabled = false;
                await UpdateProgressBarAsync();

                bool isAdded = await _packingListDapperRepository.AddAsync(newPackingList);
                btnAddPl.Enabled = true;

                if (isAdded)
                {
                    XtraMessageBox.Show("Packing List Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    progressBarControl1.Position = 0;
                    ClearFormFields();
                }
                else
                {
                    XtraMessageBox.Show("Failed to add Packing list record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    progressBarControl1.Position = 0;
                }

                btnRefreshArchiveNO_Click(this,EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in btnAddPl_Click: {ex.Message}");
                XtraMessageBox.Show("An error occurred while adding Packing list record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i += 10)
            {
                progressBarControl1.Position = i;
                await Task.Delay(10); // Simulate a small delay without blocking the UI
            }
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            var frmDescriptionForPKPL = _serviceProvider.GetRequiredService<Forms.frmSmall.frmDescriptionForPKPL>();
            frmDescriptionForPKPL.DesRecordAdded += DesRecordAddedHandler;
            frmDescriptionForPKPL.ShowDialog();
        }
        private void DesRecordAddedHandler(object? sender, EventArgs e)
        {
            var descriptionForPkService = _descriptionForPkService.GetAllDescriptionForPks();
            lookUpEditDescription.Properties.DataSource = descriptionForPkService;
        }
        private void txtPlNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a number or the backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not a number or backspace, suppress the key press
                e.Handled = true;
            }
        }

        private void btnRefreshArchiveNO_Click(object sender, EventArgs e)
        {
            RefreshArchiveNO();
        }
        private void RefreshArchiveNO()
        {
            try
            {
                var archiveNo = _packingListDapperRepository.LastArchiveNo();
                lblLastArchive.Text = archiveNo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in RefreshArchiveNO: {ex.Message}");
                XtraMessageBox.Show("An error occurred while refreshing Archive Number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFormFields()
        {
            txtPlNumber.Text = string.Empty;
            txtOpiNumber.Text = string.Empty;
            txtplName.Text = string.Empty;
            txtProject.Text = string.Empty;
            txtRemarkCustom.Text = string.Empty;
            txtinvoicenumber.Text = string.Empty;
            txtVessel.Text = string.Empty;
            txtNetWeight.Text = string.Empty;
            txtGrossWeight.Text = string.Empty;
            txtVolume.Text = string.Empty;
            txtRTINumber.Text = string.Empty;
            txtIRCNumber.Text = string.Empty;
            txtlcNumber.Text = string.Empty;
            txtBLNumber.Text = string.Empty;
            txtRemarkPl.Text = string.Empty;
            chkSite.Checked = false;
            chkBalance.Checked = false;
            txtPlNumber.Focus();
            //lookUpEditIRN.EditValue = 1;
            //LookupShipment.EditValue = 1;
            //lookUpEditMr.EditValue = 1;
            //lookUpEditPo.EditValue = 1;
            //lookUpEditAreaUnit.EditValue = 1;
            //lookUpEditSupplier.EditValue = 1;
            //lookUpEditVendor.EditValue = 1;
            //lookUpEditDescipline.EditValue = 1;
        }

    }
}
