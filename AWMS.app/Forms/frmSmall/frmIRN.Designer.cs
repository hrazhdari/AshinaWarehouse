namespace AWMS.app.Forms.frmSmall
{
    partial class frmIRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIRN));
            labelControl26 = new DevExpress.XtraEditors.LabelControl();
            labelControl25 = new DevExpress.XtraEditors.LabelControl();
            txtIRNName = new DevExpress.XtraEditors.TextEdit();
            labelControl24 = new DevExpress.XtraEditors.LabelControl();
            btnAddIRN = new DevExpress.XtraEditors.SimpleButton();
            txtIRNDescription = new DevExpress.XtraEditors.MemoEdit();
            IRNDate = new DevExpress.XtraEditors.DateEdit();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            lblIRNEnterDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtIRNName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIRNDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IRNDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IRNDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl26
            // 
            labelControl26.Appearance.ForeColor = Color.Navy;
            labelControl26.Appearance.Options.UseForeColor = true;
            labelControl26.Location = new Point(33, 134);
            labelControl26.Margin = new Padding(3, 2, 3, 2);
            labelControl26.Name = "labelControl26";
            labelControl26.Size = new Size(30, 13);
            labelControl26.TabIndex = 72;
            labelControl26.Text = "Date :";
            // 
            // labelControl25
            // 
            labelControl25.Appearance.ForeColor = Color.Navy;
            labelControl25.Appearance.Options.UseForeColor = true;
            labelControl25.Location = new Point(33, 50);
            labelControl25.Margin = new Padding(3, 2, 3, 2);
            labelControl25.Name = "labelControl25";
            labelControl25.Size = new Size(81, 13);
            labelControl25.TabIndex = 71;
            labelControl25.Text = "IRN Description :";
            // 
            // txtIRNName
            // 
            txtIRNName.Location = new Point(119, 10);
            txtIRNName.Margin = new Padding(3, 2, 3, 2);
            txtIRNName.Name = "txtIRNName";
            txtIRNName.Size = new Size(296, 20);
            txtIRNName.TabIndex = 0;
            // 
            // labelControl24
            // 
            labelControl24.Appearance.ForeColor = Color.Navy;
            labelControl24.Appearance.Options.UseForeColor = true;
            labelControl24.Location = new Point(33, 17);
            labelControl24.Margin = new Padding(3, 2, 3, 2);
            labelControl24.Name = "labelControl24";
            labelControl24.Size = new Size(55, 13);
            labelControl24.TabIndex = 70;
            labelControl24.Text = "IRN Name :";
            // 
            // btnAddIRN
            // 
            btnAddIRN.ImageOptions.Image = (Image)resources.GetObject("btnAddIRN.ImageOptions.Image");
            btnAddIRN.Location = new Point(119, 180);
            btnAddIRN.Margin = new Padding(3, 2, 3, 2);
            btnAddIRN.Name = "btnAddIRN";
            btnAddIRN.Size = new Size(296, 46);
            btnAddIRN.TabIndex = 3;
            btnAddIRN.Text = "&Add IRN";
            btnAddIRN.ToolTip = "Alt+A To Add Mr";
            btnAddIRN.Click += btnAddIRN_Click;
            // 
            // txtIRNDescription
            // 
            txtIRNDescription.Location = new Point(119, 42);
            txtIRNDescription.Margin = new Padding(3, 2, 3, 2);
            txtIRNDescription.Name = "txtIRNDescription";
            txtIRNDescription.Size = new Size(296, 80);
            txtIRNDescription.TabIndex = 1;
            // 
            // IRNDate
            // 
            IRNDate.EditValue = null;
            IRNDate.Location = new Point(119, 127);
            IRNDate.Margin = new Padding(3, 2, 3, 2);
            IRNDate.Name = "IRNDate";
            IRNDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            IRNDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            IRNDate.Properties.DisplayFormat.FormatString = "";
            IRNDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            IRNDate.Properties.EditFormat.FormatString = "";
            IRNDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            IRNDate.Properties.MaskSettings.Set("mask", "");
            IRNDate.Size = new Size(296, 20);
            IRNDate.TabIndex = 2;
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(119, 232);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(296, 18);
            progressBarControl1.TabIndex = 74;
            // 
            // lblIRNEnterDate
            // 
            lblIRNEnterDate.Appearance.ForeColor = Color.DarkGray;
            lblIRNEnterDate.Appearance.Options.UseForeColor = true;
            lblIRNEnterDate.Location = new Point(119, 158);
            lblIRNEnterDate.Margin = new Padding(3, 2, 3, 2);
            lblIRNEnterDate.Name = "lblIRNEnterDate";
            lblIRNEnterDate.Size = new Size(0, 13);
            lblIRNEnterDate.TabIndex = 75;
            // 
            // frmIRN
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(460, 268);
            Controls.Add(lblIRNEnterDate);
            Controls.Add(progressBarControl1);
            Controls.Add(btnAddIRN);
            Controls.Add(labelControl26);
            Controls.Add(labelControl25);
            Controls.Add(txtIRNName);
            Controls.Add(labelControl24);
            Controls.Add(txtIRNDescription);
            Controls.Add(IRNDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("frmIRN.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmIRN";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add IRN";
            ((System.ComponentModel.ISupportInitialize)txtIRNName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIRNDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IRNDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IRNDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit txtIRNName;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.SimpleButton btnAddIRN;
        private DevExpress.XtraEditors.MemoEdit txtIRNDescription;
        private DevExpress.XtraEditors.DateEdit IRNDate;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblIRNEnterDate;
    }
}