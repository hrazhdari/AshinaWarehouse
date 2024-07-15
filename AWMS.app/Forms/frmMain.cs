using AWMS.app.Forms.frmBase;
using AWMS.app.Utility;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AWMS.app.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;

        public frmMain(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Icon = Properties.Resources.warehouse2024;
            barStaticItem2.Caption = " :: " + DateMiladiShamsi.DateMiladi() + " : " + DateMiladiShamsi.DateShamsi();
        }

        private void CompanybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var CompanyManagementForm = _serviceProvider.GetRequiredService<frmCompanyManagment>();
            CompanyManagementForm.MdiParent = this;
            CompanyManagementForm.Show();
        }

        private void MrbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var MrManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmMr>();
            MrManagementForm.MdiParent = this;
            MrManagementForm.Show();
        }

        private void PoBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var PoManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmPo>();
            PoManagementForm.MdiParent = this;
            PoManagementForm.Show();
        }

        private void barBtnPl_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
            var PlManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmPl>();
            PlManagementForm.MdiParent = this;
            PlManagementForm.Show();
            SplashScreenManager.CloseForm();
        }

        private void barBtnPk_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);
            var PkManagementForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmPK>();
            PkManagementForm.MdiParent = this;
            PkManagementForm.Show();
            SplashScreenManager.CloseForm();
        }
    }
}
