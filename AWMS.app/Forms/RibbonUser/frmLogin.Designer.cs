namespace AWMS.app.Forms.RibbonUser
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            btnEnter = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            error = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(272, 80);
            txtUserName.Name = "txtUserName";
            txtUserName.Properties.Appearance.Font = new Font("Tahoma", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Properties.Appearance.Options.UseFont = true;
            txtUserName.Size = new Size(195, 26);
            txtUserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(199, 86);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(67, 14);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "UserName :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(199, 120);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(68, 14);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "PassWord :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(272, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new Font("Tahoma", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.PasswordChar = '*';
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(195, 26);
            txtPassword.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Appearance.Font = new Font("Tahoma", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Appearance.Options.UseFont = true;
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.ImageOptions.Image = Properties.Resources.editrangepermission_32x32;
            btnEnter.Location = new Point(272, 156);
            btnEnter.Name = "btnEnter";
            btnEnter.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            btnEnter.Size = new Size(95, 38);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.Click += btnEnter_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Cursor = Cursors.Hand;
            simpleButton1.ImageOptions.Image = Properties.Resources.clear_32x32;
            simpleButton1.Location = new Point(382, 156);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(85, 38);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Cancel";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // error
            // 
            error.Appearance.Font = new Font("Tahoma", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            error.Appearance.ForeColor = Color.Red;
            error.Appearance.Options.UseFont = true;
            error.Appearance.Options.UseForeColor = true;
            error.Location = new Point(208, 222);
            error.Name = "error";
            error.Size = new Size(0, 17);
            error.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayoutStore = ImageLayout.Center;
            BackgroundImageStore = Properties.Resources.Login2;
            ClientSize = new Size(498, 375);
            Controls.Add(error);
            Controls.Add(simpleButton1);
            Controls.Add(btnEnter);
            Controls.Add(labelControl2);
            Controls.Add(txtPassword);
            Controls.Add(labelControl1);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ashina WareHouse Login ";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl error;
    }
}