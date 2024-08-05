using AWMS.app.Utility;
using AWMS.dapper.Repositories;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Forms.RibbonUser
{
    public partial class frmLogin : XtraForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserDapperRepository _userDapperRepository;

        public frmLogin(IServiceProvider serviceProvider, IUserDapperRepository userDapperRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userDapperRepository = userDapperRepository;

            this.KeyDown += new KeyEventHandler(frmLogin_KeyDown);
            this.AcceptButton = btnEnter;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // کد بارگذاری فرم (اگر نیاز است)
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string passwordHash = txtPassword.Text; // فرض بر این است که تابع HashPassword وجود دارد

            var user = await _userDapperRepository.GetUserByUsernameAsync(username);

            if (user != null && user.PasswordHash == passwordHash)
            {
                var session = new UserSession
                {
                    UserID = user.UserID,
                    Username = user.Username,
                    RoleID = user.RoleID
                };

                SessionManager.AddSession(user.UserID, session);

                var scope = _serviceProvider.CreateScope();
                var serviceProvider = scope.ServiceProvider;
                var userContext = serviceProvider.GetRequiredService<UserContext>();
                userContext.UserId = user.UserID;
                userContext.Username = user.Username;
                userContext.RoleID = user.RoleID;

                var mainForm = serviceProvider.GetRequiredService<frmMain>();
                mainForm.MdiParent = this.MdiParent; // برای تنظیم فرم اصلی به عنوان والد
                mainForm.Show();
                this.Hide();
            }
            else
            {
                error.Text = "The username or password is incorrect.";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtUserName.Focus();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, e);
            }
        }
    }
}
