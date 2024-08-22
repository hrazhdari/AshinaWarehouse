using AWMS.app.Forms.frmBase;
using AWMS.app.Forms.RibbonMaterial;
using AWMS.app.Forms.RibbonUser;
using AWMS.app.Forms.RibbonVoucher;
using AWMS.app.Utility;
using AWMS.core.Interfaces;
using AWMS.dapper.Repositories;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AWMS.app.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserContext _userContext;

        public frmMain(IServiceProvider serviceProvider, UserContext userContext)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userContext = userContext;
            this.Icon = Properties.Resources.warehouse2024;
            barStaticItem2.Caption = " :: " + DateMiladiShamsi.DateMiladi() + " : " + DateMiladiShamsi.DateShamsi();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_userContext != null)
            {
                barStaticItem3.Caption = $"Welcome, {_userContext.Username}";
            }
        }

        private void CompanybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var CompanyManagementForm = _serviceProvider.GetRequiredService<frmCompanyManagment>();
                CompanyManagementForm.MdiParent = this;
                CompanyManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
        private void barBtnContracts_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var CompanyContractForm = ActivatorUtilities.CreateInstance<frmCompanyContract>(_serviceProvider, _userContext.UserId);
                CompanyContractForm.MdiParent = this;
                CompanyContractForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
        private void MrbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var MrManagementForm = _serviceProvider.GetRequiredService<frmMr>();
                MrManagementForm.MdiParent = this;
                MrManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void PoBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var PoManagementForm = _serviceProvider.GetRequiredService<frmPo>();
                PoManagementForm.MdiParent = this;
                PoManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void barBtnPl_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var PlManagementForm = ActivatorUtilities.CreateInstance<frmPl>(
                    _serviceProvider,
                    _userContext.UserId,  // به درستی پارامتر userId ارسال می‌شود
                    _serviceProvider.GetRequiredService<IPackingListDapperRepository>(),
                    _serviceProvider.GetRequiredService<IServiceProvider>(),
                    _serviceProvider.GetRequiredService<IDescriptionForPkService>(),
                    _serviceProvider.GetRequiredService<IIrnService>(),
                    _serviceProvider.GetRequiredService<IShipmentService>(),
                    _serviceProvider.GetRequiredService<IAreaUnitService>(),
                    _serviceProvider.GetRequiredService<IVendorService>(),
                    _serviceProvider.GetRequiredService<ISupplierService>(),
                    _serviceProvider.GetRequiredService<IDesciplineService>(),
                    _serviceProvider.GetRequiredService<IMrService>(),
                    _serviceProvider.GetRequiredService<IPoService>()
                );
                PlManagementForm.MdiParent = this;
                PlManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void barBtnPk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var PkManagementForm = ActivatorUtilities.CreateInstance<frmPK>(_serviceProvider, _userContext.UserId);
                PkManagementForm.MdiParent = this;
                PkManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var ItemLocManagementForm = ActivatorUtilities.CreateInstance<frmItemLoc>(_serviceProvider, _userContext.UserId);
                ItemLocManagementForm.MdiParent = this;
                ItemLocManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var viewPackingListForm = ActivatorUtilities.CreateInstance<frmViewPackingList>(_serviceProvider, _userContext.UserId);
                viewPackingListForm.MdiParent = this;
                viewPackingListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void barbtnImportPackingList_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var ImportPackingListForm = ActivatorUtilities.CreateInstance<frmImportPackingList>(_serviceProvider, _userContext.UserId);
                ImportPackingListForm.MdiParent = this;
                ImportPackingListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void btnmiv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
                var ImportPackingListForm = ActivatorUtilities.CreateInstance<frmIssueVoucher>(_serviceProvider);//, _userContext.UserId);
                ImportPackingListForm.MdiParent = this;
                ImportPackingListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}
