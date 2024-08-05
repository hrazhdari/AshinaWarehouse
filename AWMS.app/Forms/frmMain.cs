using AWMS.app.Forms.frmBase;
using AWMS.app.Forms.RibbonMaterial;
using AWMS.app.Forms.RibbonUser;
using AWMS.app.Utility;
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
                barStaticItem3.Caption = $"Welcome, {_userContext.Username}"; //+ " " + $"Role: {_userContext.RoleID}";
            }
        }

        private void CompanybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var CompanyManagementForm = _serviceProvider.GetRequiredService<frmCompanyManagment>();
            CompanyManagementForm.MdiParent = this;
            CompanyManagementForm.Show();
        }

        private void MrbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var MrManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmMr>();
            MrManagementForm.MdiParent = this;
            MrManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void PoBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
            var PoManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmPo>();
            PoManagementForm.MdiParent = this;
            PoManagementForm.Show();
            SplashScreenManager.CloseForm();
        }

        private void barBtnPl_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var PlManagementForm = ActivatorUtilities.CreateInstance<frmPl>(_serviceProvider, _userContext.UserId);
            PlManagementForm.MdiParent = this;
            PlManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barBtnPk_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var PkManagementForm = ActivatorUtilities.CreateInstance<frmPK>(_serviceProvider, _userContext.UserId);
            PkManagementForm.MdiParent = this;
            PkManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var ItemLocManagementForm = ActivatorUtilities.CreateInstance<frmItemLoc>(_serviceProvider, _userContext.UserId);
            ItemLocManagementForm.MdiParent = this;
            ItemLocManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var viewPackingListForm = ActivatorUtilities.CreateInstance<frmViewPackingList>(_serviceProvider, _userContext.UserId);
            viewPackingListForm.MdiParent = this;
            viewPackingListForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barbtnImportPackingList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            var ImportPackingListForm = ActivatorUtilities.CreateInstance<frmImportPackingList>(_serviceProvider, _userContext.UserId);
            ImportPackingListForm.MdiParent = this;
            ImportPackingListForm.Show();

            SplashScreenManager.CloseForm();
        }
    }
}
