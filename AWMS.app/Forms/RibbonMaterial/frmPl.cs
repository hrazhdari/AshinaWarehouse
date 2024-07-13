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
        private BackgroundWorker backgroundWorker;
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDescriptionForPkService _descriptionForPkService;
        private bool _isRowAdded;
        public frmPl(IPackingListDapperRepository PackingListDapperRepository, IServiceProvider serviceProvider, IDescriptionForPkService descriptionForPkService)
        {
            InitializeComponent();
            _packingListDapperRepository = PackingListDapperRepository;
            lblEnteredPlDate.Text = DateTime.Now.ToString();
            _serviceProvider = serviceProvider;
            this._descriptionForPkService = descriptionForPkService;

            LoadLoolUps();
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
        private void LoadLoolUps()
        {
            DesRecordAddedHandler(null, null);
        }
        private void txtPlNumber_Leave(object sender, EventArgs e)
        {
            string plNo = txtPlNumber.Text.Trim();
            if (plNo == "") { return; }
            bool isDuplicate = IsDuplicatePLNO(plNo);
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
        private bool IsDuplicatePLNO(string plNo)
        {
            //var duplicatePLNO = _unitOfWork.PlRepository.GetPlByPlNo(plNo);
            return false; //duplicatePLNO != null;
        }

        private async void txtplName_Leave(object sender, EventArgs e)
        {
            string plName = txtplName.Text.Trim();
            if (plName == "") return;
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
                Console.WriteLine($"Exception in txtplName_TextChanged: {ex.Message}");
            }
        }

        private async Task<bool> IsDuplicatePLName(string plName)
        {

            try
            {
                bool isDuplicate = await _packingListDapperRepository.ExistsByPlNameAsync(plName);
                return isDuplicate;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        private void btnAddIrn_Click(object sender, EventArgs e)
        {
            //When I Don't Want Refresh Any Data
            //frmIRN frmirn = new frmIRN(attachEventHandler: false);
            //frmIRN frmirn = new frmIRN();
            //frmirn.IRNRecordAdded += IRNRecordAddedHandler;
            //frmirn.ShowDialog();
        }
        private void IRNRecordAddedHandler(object sender, EventArgs e)
        {
            //_irnList = _unitOfWork.IrnRepository.GetAllIrn().ToList();
            //irnBindingSource.DataSource = _irnList;
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            //frmShipment frmship = new frmShipment();
            //frmship.ShipRecordAdded += ShipRecordAddedHandler;
            //frmship.ShowDialog();
        }
        private void ShipRecordAddedHandler(object sender, EventArgs e)
        {
            //_shipList = _unitOfWork.ShipRepository.GetAllShipment().ToList();
            //shipmentBindingSource.DataSource = _shipList;
        }

        private void RefreshMr_Click(object sender, EventArgs e)
        {
            //_mrList = _unitOfWork.MrRepository.GetAllMr().ToList();
            //mrBindingSource.DataSource = _mrList;
        }

        private void RefreshPO_Click(object sender, EventArgs e)
        {
            //_poList = _unitOfWork.PoRepository.GetAllPo().ToList();
            //poBindingSource.DataSource = _poList;
        }

        private void btnInsertArea_Click(object sender, EventArgs e)
        {
            //frmAreaUnit frmarea = new frmAreaUnit();
            //frmarea.AreaRecordAdded += areaRecordAddedHandler;
            //frmarea.ShowDialog();
        }
        private void areaRecordAddedHandler(object sender, EventArgs e)
        {
            //_areaList = _unitOfWork.AreaRepository.GetAllAreaUnit().ToList();
            //areaUnitBindingSource.DataSource = _areaList;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            //frmSupplier frmsupplier = new frmSupplier();
            //frmsupplier.SupplierRecordAdded += supplierRecordAddedHandler;
            //frmsupplier.ShowDialog();
        }
        private void supplierRecordAddedHandler(object sender, EventArgs e)
        {
            //_supplierList = _unitOfWork.SupplierRepository.GetAllSupplier().ToList();
            //supplierBindingSource.DataSource = _supplierList;
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            //frmVendor frmvendor = new frmVendor();
            //frmvendor.VendorRecordAdded += vendorRecordAddedHandler;
            //frmvendor.ShowDialog();
        }
        private void vendorRecordAddedHandler(object sender, EventArgs e)
        {
            //_vendorList = _unitOfWork.VendorRepository.GetAllVendor().ToList();
            //vendorBindingSource.DataSource = _vendorList;
        }
        private async void txtOpiNumber_Leave(object sender, EventArgs e)
        {
            string OpiNumber = txtOpiNumber.Text.Trim();
            if (OpiNumber == "") { return; }
            try
            {

                bool isDuplicate = await IsDuplicateOpiNumber(OpiNumber);

                if (isDuplicate)
                {
                    MessageBox.Show("Warning: Duplicate OpiNumber Name found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                //Console.WriteLine($"Exception in txtplName_TextChanged: {ex.Message}");
            }
        }
        private async Task<bool> IsDuplicateOpiNumber(string OpiNumber)
        {
            //if (_unitOfWork != null && _unitOfWork.PlRepository != null)
            //{
            //    try
            //    {
            //        bool isDuplicate = await _unitOfWork.PlRepository.GetPlByPlOpiNoBoolAsync(OpiNumber);
            //        return isDuplicate;
            //    }
            //    catch (Exception ex)
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    // Handle the case where _unitOfWork or _unitOfWork.PlRepository is null
            return false;
            //}
        }

        private async void btnAddPl_Click(object sender, EventArgs e)
        {
            string plArchive;
            string plName;
            int DesciplineId;
            if (lblDuplicate.Text == "Duplicate !")
            {
                MessageBox.Show("Warning: Duplicate PL Number found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDuplicate.Text = "Duplicate !";
                lblDuplicate.ForeColor = Color.Red;
                txtPlNumber.BackColor = Color.OrangeRed;
                txtPlNumber.Focus();
                return;
            }
            else
            {
                plArchive = string.IsNullOrWhiteSpace(txtPlNumber.Text) ? null : txtPlNumber.Text.Trim();
            }
            string plNumber = string.IsNullOrWhiteSpace(txtPlNumber.Text) ? null : txtPlNumber.Text.Trim();
            string opiNumber = string.IsNullOrWhiteSpace(txtOpiNumber.Text) ? null : txtOpiNumber.Text.Trim();
            string invoiceNumber = string.IsNullOrWhiteSpace(txtinvoicenumber.Text) ? null : txtinvoicenumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtplName.Text))
            {
                MessageBox.Show("Warning: Please Enter Pl Name!", "NOT Entered Pl Name Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblduplicateplname.Text = "Please Enter Pl Name!";
                lblduplicateplname.ForeColor = Color.Coral;
                txtplName.BackColor = Color.OrangeRed;
                txtplName.Focus();
                return;
            }
            else if (lblduplicateplname.Text == "Duplicate !")
            {
                MessageBox.Show("Warning: Duplicate PL Number found!", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblduplicateplname.Text = "Duplicate !";
                lblduplicateplname.ForeColor = Color.Red;
                txtplName.BackColor = Color.OrangeRed;
                txtplName.Focus();
                return;
            }
            else
            {
                lblduplicateplname.Text = "";
                txtplName.BackColor = Color.White;
                plName = txtplName.Text.Trim();
            }
            int plDescription = lookUpEditDescription.EditValue == null ? 1 : Convert.ToInt32(lookUpEditDescription.EditValue);
            int IrnId = lookUpEditIRN.EditValue == null ? 1 : Convert.ToInt32(lookUpEditIRN.EditValue);
            int ShipId = LookupShipment.EditValue == null ? 1 : Convert.ToInt32(LookupShipment.EditValue);
            int MrId = lookUpEditMr.EditValue == null ? 1 : Convert.ToInt32(lookUpEditMr.EditValue);
            int PoId = lookUpEditPo.EditValue == null ? 1 : Convert.ToInt32(lookUpEditPo.EditValue);
            int AreaId = lookUpEditAreaUnit.EditValue == null ? 1 : Convert.ToInt32(lookUpEditAreaUnit.EditValue);
            int SupplierId = lookUpEditSupplier.EditValue == null ? 1 : Convert.ToInt32(lookUpEditSupplier.EditValue);
            int VendorId = lookUpEditVendor.EditValue == null ? 1 : Convert.ToInt32(lookUpEditVendor.EditValue);
            int LocalForeign = radioGroup1.SelectedIndex != -1 ? radioGroup1.SelectedIndex + 1 : 1;
            string Vessel = string.IsNullOrWhiteSpace(txtVessel.Text) ? null : txtVessel.Text.Trim();
            if (lookUpEditDescipline.EditValue == null)
            {
                MessageBox.Show("Warning: Please Select Descipline!", "NOT Selected Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMostSelectDescipline.Text = "Please Select Descipline!";
                lblMostSelectDescipline.ForeColor = Color.Red;
                lookUpEditDescipline.BackColor = Color.OrangeRed;
                lookUpEditDescipline.Focus();
                return;
            }
            else
            {
                lblMostSelectDescipline.Text = "";
                lookUpEditDescipline.BackColor = Color.White;
                DesciplineId = Convert.ToInt32(lookUpEditDescipline.EditValue);
            }
            decimal NetWeight = string.IsNullOrWhiteSpace(txtNetWeight.Text) ? 0 : Convert.ToDecimal(txtNetWeight.Text);
            decimal GrossWeight = string.IsNullOrWhiteSpace(txtGrossWeight.Text) ? 0 : Convert.ToDecimal(txtGrossWeight.Text);
            string Volume = string.IsNullOrWhiteSpace(txtVolume.Text) ? null : txtVolume.Text.Trim();
            string RemarkPl = string.IsNullOrWhiteSpace(txtRemarkPl.Text) ? null : txtRemarkPl.Text.Trim();
            DateTime MARDate = MARPLDate.DateTime != DateTime.MinValue ? MARPLDate.DateTime : DateTime.Now;
            string Project = string.IsNullOrWhiteSpace(txtProject.Text) ? null : txtProject.Text.Trim();
            string RtiNumber = string.IsNullOrWhiteSpace(txtRTINumber.Text) ? null : txtRTINumber.Text.Trim();
            string IRCNumber = string.IsNullOrWhiteSpace(txtIRCNumber.Text) ? null : txtIRCNumber.Text.Trim();
            string LCNumber = string.IsNullOrWhiteSpace(txtlcNumber.Text) ? null : txtlcNumber.Text.Trim();
            string BLNumber = string.IsNullOrWhiteSpace(txtBLNumber.Text) ? null : txtBLNumber.Text.Trim();
            string RemarkCustom = string.IsNullOrWhiteSpace(txtRemarkCustom.Text) ? null : txtRemarkCustom.Text.Trim();
            bool SiteCheck = chkSite.Checked ? true : false;
            bool BalanceCheck = chkBalance.Checked ? true : false;

            //PackingList newpackinglist = new PackingList
            //{
            //    ArchiveNO= plArchive,
            //    PLNO= plNumber,
            //    OPINO= opiNumber,
            //    InvoiceNO= invoiceNumber,
            //    PLName= plName,
            //    DescriptionForPkId = plDescription,
            //    IrnId= IrnId,
            //    ShId= ShipId,
            //    MrId=MrId,
            //    PoId= PoId,
            //    AreaUnitID= AreaId,
            //    SupplierId= SupplierId,
            //    VendorId= VendorId,
            //    LocalForeign= LocalForeign,
            //    Vessel= Vessel,
            //    DesciplineId= DesciplineId,
            //    NetW=NetWeight,
            //    GrossW=GrossWeight,
            //    Volume= Volume,
            //    Remark=RemarkPl,
            //    MARDate= MARDate,
            //    Project= Project,
            //    RTINO=RtiNumber,
            //    IRCNO=IRCNumber,
            //    LCNO=LCNumber,
            //    BLNO= BLNumber,
            //    Remarkcustoms=RemarkCustom,
            //    SitePL=SiteCheck,
            //    Balance=BalanceCheck
            //};

            btnAddPl.Enabled = false;

            await UpdateProgressBarAsync();

            //bool isAdded = await AddPlRecordAsync(newpackinglist);
            bool isAdded = false;
            btnAddPl.Enabled = true;

            if (isAdded)
            {
                XtraMessageBox.Show("Packing list record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;
                txtPlNumber.Text = string.Empty;
                txtOpiNumber.Text = string.Empty;
                txtplName.Text = string.Empty;
                txtProject.Text = string.Empty;
                txtRemarkCustom.Text = string.Empty;
                txtBLNumber.Text = string.Empty;
                txtinvoicenumber.Text = string.Empty;
                txtIRCNumber.Text = string.Empty;
                txtlcNumber.Text = string.Empty;
                txtGrossWeight.Text = string.Empty;
                txtNetWeight.Text = string.Empty;
                txtRemarkPl.Text = string.Empty;
                txtVessel.Text = string.Empty;
                txtVolume.Text = string.Empty;
                txtRTINumber.Text = string.Empty;
                lblEnterDate.Text = DateTime.Now.ToString();
                chkBalance.Checked = false;
                chkSite.Checked = false;
                radioGroup1.SelectedIndex = 0;
                txtPlNumber.Focus();
            }
            else
            {
                XtraMessageBox.Show("Failed to add Packing list record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;
            }
            //lblLastArchive.Text = _unitOfWork.PlRepository.GetLAstArcvhiveNo();
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBarControl1.Position = i;

                // Simulate a small delay without blocking the UI
                await Task.Delay(5); // Adjust the delay time if needed
            }
        }
        //private async Task<bool> AddPlRecordAsync(PackingList newpackinglist)
        //{
        //    try
        //    {
        //        // Add the Mr record to the database asynchronously
        //        return await Task.Run(() => _unitOfWork.PlRepository.Addpl(newpackinglist));
        //    }
        //    catch (Exception)
        //    {
        //        // Handle exception (log, throw, etc.)
        //        return false;
        //    }
        //}

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            //frmDescriptionForPKPL frmDescriptionForPKPL = new frmDescriptionForPKPL();
            //frmDescriptionForPKPL.DesRecordAdded += DesRecordAddedHandler;
            //frmDescriptionForPKPL.ShowDialog();
            var frmDescriptionForPKPL = _serviceProvider.GetRequiredService<Forms.frmSmall.frmDescriptionForPKPL>();
            frmDescriptionForPKPL.DesRecordAdded += DesRecordAddedHandler;
            frmDescriptionForPKPL.ShowDialog();
        }
        private void DesRecordAddedHandler(object sender, EventArgs e)
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
            //using(DatabaseContext _context=new DatabaseContext())
            //{
            //    var packingLists = _context.PackingLists.ToList();

            //    if (packingLists.Any())
            //    {
            //        string lastArchiveNo = packingLists
            //                                   .OrderByDescending(pl =>
            //                                       int.TryParse(pl.ArchiveNO, out int result) ? result : 0)
            //                                   .Select(pl => pl.ArchiveNO)
            //                                   .FirstOrDefault();

            //        lblLastArchive.Text = lastArchiveNo;
            //    }
            //    else
            //    {

            //        lblLastArchive.Text = "0";
            //    }
            //}

        }

        private void frmPl_FormClosed(object sender, FormClosedEventArgs e)
        {

            //_unitOfWork.Dispose();
            //_dbContextWithoutUnitOfWork.Dispose();

        }









        //private async void btnGetPackingList_Click(object sender, EventArgs e)
        //{
        //    int idToFetch = Convert.ToInt32(txtPackingListId.Text);

        //    try
        //    {
        //        PackingListDto packingList = await _repository.GetByIdAsync(idToFetch);
        //        // Use the fetched packingList object to populate your UI or perform other operations
        //        DisplayPackingListDetails(packingList);
        //    }
        //    catch (KeyNotFoundException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Packing List Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void DisplayPackingListDetails(PackingListDto packingList)
        //{
        //    // Example: Display details in TextBoxes or other UI controls
        //    txtName.Text = packingList.PLName;
        //    txtArchiveNO.Text = packingList.ArchiveNO.ToString();
        //    // Populate other UI elements as needed
        //}
    }
}
