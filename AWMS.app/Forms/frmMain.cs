using AWMS.app.Forms.frmBase;
using AWMS.app.Forms.RibbonMaterial;
using AWMS.app.Forms.RibbonUser;
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
        private readonly int _userId;
        private readonly UserSession _session; // اضافه کردن متغیر سراسری برای UserSession

        public frmMain(IServiceProvider serviceProvider, int userId)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this.Icon = Properties.Resources.warehouse2024;
            barStaticItem2.Caption = " :: " + DateMiladiShamsi.DateMiladi() + " : " + DateMiladiShamsi.DateShamsi();
            _userId = userId;

            // گرفتن نشست کاربر و ذخیره آن در متغیر سراسری
            _session = SessionManager.GetSession(_userId);
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

            // ایجاد فرم جدید و پاس دادن userId
            var PlManagementForm = ActivatorUtilities.CreateInstance<frmPl>(_serviceProvider, _userId);
            PlManagementForm.MdiParent = this;
            PlManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barBtnPk_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            // ایجاد فرم جدید و پاس دادن userId
            var PkManagementForm = ActivatorUtilities.CreateInstance<frmPK>(_serviceProvider, _userId);
            PkManagementForm.MdiParent = this;
            PkManagementForm.Show();

            SplashScreenManager.CloseForm();
        }


        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            // ایجاد فرم جدید و پاس دادن userId
            var ItemLocManagementForm = ActivatorUtilities.CreateInstance<frmItemLoc>(_serviceProvider, _userId);
            ItemLocManagementForm.MdiParent = this;
            ItemLocManagementForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            // ایجاد فرم جدید و پاس دادن userId
            var viewPackingListForm = ActivatorUtilities.CreateInstance<frmViewPackingList>(_serviceProvider, _userId);
            viewPackingListForm.MdiParent = this;
            viewPackingListForm.Show();

            SplashScreenManager.CloseForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_session != null)
            {
                barStaticItem3.Caption = $"Welcome, {_session.Username}"; //+ " " + $"Role: {_session.RoleID}";
                //RoleLabel.Text = $"Role: {_session.Role}";
            }
        }

        private void barbtnImportPackingList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWait), true, true, true, false);

            // ایجاد فرم جدید و پاس دادن userId
            var ImportPackingListForm = ActivatorUtilities.CreateInstance<frmImportPackingList>(_serviceProvider, _userId);
            ImportPackingListForm.MdiParent = this;
            ImportPackingListForm.Show();

            SplashScreenManager.CloseForm();
        }
    }
}
