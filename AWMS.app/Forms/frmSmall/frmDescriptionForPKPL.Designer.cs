namespace AWMS.app.Forms.frmSmall
{
    partial class frmDescriptionForPKPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescriptionForPKPL));
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            btnAddDescription = new DevExpress.XtraEditors.SimpleButton();
            labelControl25 = new DevExpress.XtraEditors.LabelControl();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            SuspendLayout();
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(125, 157);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(296, 18);
            progressBarControl1.TabIndex = 83;
            // 
            // btnAddDescription
            // 
            btnAddDescription.ImageOptions.Image = (Image)resources.GetObject("btnAddDescription.ImageOptions.Image");
            btnAddDescription.Location = new Point(125, 106);
            btnAddDescription.Margin = new Padding(3, 2, 3, 2);
            btnAddDescription.Name = "btnAddDescription";
            btnAddDescription.Size = new Size(296, 46);
            btnAddDescription.TabIndex = 79;
            btnAddDescription.Text = "&Add Description";
            btnAddDescription.ToolTip = "Alt+A To Add Mr";
            btnAddDescription.Click += btnAddDescription_Click;
            // 
            // labelControl25
            // 
            labelControl25.Appearance.ForeColor = Color.Navy;
            labelControl25.Appearance.Options.UseForeColor = true;
            labelControl25.Location = new Point(39, 17);
            labelControl25.Margin = new Padding(3, 2, 3, 2);
            labelControl25.Name = "labelControl25";
            labelControl25.Size = new Size(60, 13);
            labelControl25.TabIndex = 81;
            labelControl25.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 10);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 80);
            txtDescription.TabIndex = 77;
            // 
            // frmDescriptionForPKPL
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 186);
            Controls.Add(progressBarControl1);
            Controls.Add(btnAddDescription);
            Controls.Add(labelControl25);
            Controls.Add(txtDescription);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("frmDescriptionForPKPL.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmDescriptionForPKPL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Description PL";
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddDescription;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}