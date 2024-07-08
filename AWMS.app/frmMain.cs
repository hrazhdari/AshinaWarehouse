using AWMS.app.Utility;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace AWMS.app
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        public frmMain(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Icon = Properties.Resources.warehouse2024;
            toolStripStatusLabel1.Caption = " :~:  " + DateMiladiShamsi.DateMiladi() + " :: " + DateMiladiShamsi.DateShamsi();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void companyManagementToolStripMenuItem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var CompanyManagmentForm = _serviceProvider.GetRequiredService<Forms.frmCompanyManagment>();
            //CompanyManagmentForm.ShowDialog();
            //CompanyManagmentForm.MdiParent = this;
            CompanyManagmentForm.ShowDialog();
        }
    }
}
