namespace AWMS.app.Forms.frmSmall
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblSuplierEnterDate = new DevExpress.XtraEditors.LabelControl();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            btnAddSupplier = new DevExpress.XtraEditors.SimpleButton();
            labelControl26 = new DevExpress.XtraEditors.LabelControl();
            labelControl25 = new DevExpress.XtraEditors.LabelControl();
            txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            labelControl24 = new DevExpress.XtraEditors.LabelControl();
            txtSupplierDescription = new DevExpress.XtraEditors.MemoEdit();
            SupplierDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplierDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SupplierDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SupplierDate.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.ForeColor = Color.Navy;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(33, 75);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(43, 13);
            labelControl1.TabIndex = 98;
            labelControl1.Text = "Remark :";
            // 
            // lblSuplierEnterDate
            // 
            lblSuplierEnterDate.Appearance.ForeColor = Color.DarkGray;
            lblSuplierEnterDate.Appearance.Options.UseForeColor = true;
            lblSuplierEnterDate.Location = new Point(123, 163);
            lblSuplierEnterDate.Margin = new Padding(3, 2, 3, 2);
            lblSuplierEnterDate.Name = "lblSuplierEnterDate";
            lblSuplierEnterDate.Size = new Size(20, 13);
            lblSuplierEnterDate.TabIndex = 97;
            lblSuplierEnterDate.Text = ".....";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(123, 239);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(305, 18);
            progressBarControl1.TabIndex = 96;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.ImageOptions.Image = (Image)resources.GetObject("btnAddSupplier.ImageOptions.Image");
            btnAddSupplier.Location = new Point(123, 188);
            btnAddSupplier.Margin = new Padding(3, 2, 3, 2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(305, 46);
            btnAddSupplier.TabIndex = 3;
            btnAddSupplier.Text = "&Add Supplier";
            btnAddSupplier.ToolTip = "Alt+A To Add Mr";
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // labelControl26
            // 
            labelControl26.Appearance.ForeColor = Color.Navy;
            labelControl26.Appearance.Options.UseForeColor = true;
            labelControl26.Location = new Point(33, 145);
            labelControl26.Margin = new Padding(3, 2, 3, 2);
            labelControl26.Name = "labelControl26";
            labelControl26.Size = new Size(30, 13);
            labelControl26.TabIndex = 94;
            labelControl26.Text = "Date :";
            // 
            // labelControl25
            // 
            labelControl25.Appearance.ForeColor = Color.Navy;
            labelControl25.Appearance.Options.UseForeColor = true;
            labelControl25.Location = new Point(33, 61);
            labelControl25.Margin = new Padding(3, 2, 3, 2);
            labelControl25.Name = "labelControl25";
            labelControl25.Size = new Size(38, 13);
            labelControl25.TabIndex = 93;
            labelControl25.Text = "Supplier";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(123, 17);
            txtSupplierName.Margin = new Padding(3, 2, 3, 2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(305, 20);
            txtSupplierName.TabIndex = 0;
            // 
            // labelControl24
            // 
            labelControl24.Appearance.ForeColor = Color.Navy;
            labelControl24.Appearance.Options.UseForeColor = true;
            labelControl24.Location = new Point(32, 21);
            labelControl24.Margin = new Padding(3, 2, 3, 2);
            labelControl24.Name = "labelControl24";
            labelControl24.Size = new Size(75, 13);
            labelControl24.TabIndex = 92;
            labelControl24.Text = "Supplier Name :";
            // 
            // txtSupplierDescription
            // 
            txtSupplierDescription.Location = new Point(123, 50);
            txtSupplierDescription.Margin = new Padding(3, 2, 3, 2);
            txtSupplierDescription.Name = "txtSupplierDescription";
            txtSupplierDescription.Size = new Size(305, 80);
            txtSupplierDescription.TabIndex = 1;
            // 
            // SupplierDate
            // 
            SupplierDate.EditValue = null;
            SupplierDate.Location = new Point(123, 137);
            SupplierDate.Margin = new Padding(3, 2, 3, 2);
            SupplierDate.Name = "SupplierDate";
            SupplierDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            SupplierDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            SupplierDate.Properties.DisplayFormat.FormatString = "";
            SupplierDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            SupplierDate.Properties.EditFormat.FormatString = "";
            SupplierDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            SupplierDate.Properties.MaskSettings.Set("mask", "");
            SupplierDate.Size = new Size(305, 20);
            SupplierDate.TabIndex = 2;
            // 
            // frmSupplier
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 271);
            Controls.Add(labelControl1);
            Controls.Add(lblSuplierEnterDate);
            Controls.Add(progressBarControl1);
            Controls.Add(btnAddSupplier);
            Controls.Add(labelControl26);
            Controls.Add(labelControl25);
            Controls.Add(txtSupplierName);
            Controls.Add(labelControl24);
            Controls.Add(txtSupplierDescription);
            Controls.Add(SupplierDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("frmSupplier.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Supplier";
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplierName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSupplierDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SupplierDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SupplierDate.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSuplierEnterDate;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit txtSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.MemoEdit txtSupplierDescription;
        private DevExpress.XtraEditors.DateEdit SupplierDate;
    }
}