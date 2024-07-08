namespace AWMS.app
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            companyManagementToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightBlue;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(922, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { companyManagementToolStripMenuItem });
            toolStripDropDownButton1.ForeColor = Color.Black;
            toolStripDropDownButton1.Image = Properties.Resources.icons8_management_32;
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(123, 36);
            toolStripDropDownButton1.Text = "Management";
            // 
            // companyManagementToolStripMenuItem
            // 
            companyManagementToolStripMenuItem.Image = Properties.Resources.icons8_company_16;
            companyManagementToolStripMenuItem.Name = "companyManagementToolStripMenuItem";
            companyManagementToolStripMenuItem.Size = new Size(200, 22);
            companyManagementToolStripMenuItem.Text = "Company Management";
            companyManagementToolStripMenuItem.Click += companyManagementToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.LightBlue;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 644);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(922, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(109, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(922, 666);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            HelpButton = true;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AWMS :: Ashina Warehouse Management Software";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem companyManagementToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
