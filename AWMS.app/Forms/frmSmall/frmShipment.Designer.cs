namespace AWMS.app.Forms.frmSmall
{
    partial class frmShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipment));
            lblIRNEnterDate = new DevExpress.XtraEditors.LabelControl();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            btnAddShipment = new DevExpress.XtraEditors.SimpleButton();
            labelControl26 = new DevExpress.XtraEditors.LabelControl();
            labelControl25 = new DevExpress.XtraEditors.LabelControl();
            txtShipmentName = new DevExpress.XtraEditors.TextEdit();
            labelControl24 = new DevExpress.XtraEditors.LabelControl();
            txtShipmentDescription = new DevExpress.XtraEditors.MemoEdit();
            ShipmentDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lookUpEditPo = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtShipmentName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtShipmentDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPo.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblIRNEnterDate
            // 
            lblIRNEnterDate.Appearance.ForeColor = Color.DarkGray;
            lblIRNEnterDate.Appearance.Options.UseForeColor = true;
            lblIRNEnterDate.Location = new Point(129, 203);
            lblIRNEnterDate.Margin = new Padding(3, 2, 3, 2);
            lblIRNEnterDate.Name = "lblIRNEnterDate";
            lblIRNEnterDate.Size = new Size(20, 13);
            lblIRNEnterDate.TabIndex = 84;
            lblIRNEnterDate.Text = ".....";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(129, 279);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(305, 18);
            progressBarControl1.TabIndex = 83;
            // 
            // btnAddShipment
            // 
            btnAddShipment.ImageOptions.Image = (Image)resources.GetObject("btnAddShipment.ImageOptions.Image");
            btnAddShipment.Location = new Point(129, 228);
            btnAddShipment.Margin = new Padding(3, 2, 3, 2);
            btnAddShipment.Name = "btnAddShipment";
            btnAddShipment.Size = new Size(305, 46);
            btnAddShipment.TabIndex = 4;
            btnAddShipment.Text = "&Add Shipment";
            btnAddShipment.ToolTip = "Alt+A To Add Mr";
            btnAddShipment.Click += btnAddShipment_Click;
            // 
            // labelControl26
            // 
            labelControl26.Appearance.ForeColor = Color.Navy;
            labelControl26.Appearance.Options.UseForeColor = true;
            labelControl26.Location = new Point(39, 184);
            labelControl26.Margin = new Padding(3, 2, 3, 2);
            labelControl26.Name = "labelControl26";
            labelControl26.Size = new Size(30, 13);
            labelControl26.TabIndex = 81;
            labelControl26.Text = "Date :";
            // 
            // labelControl25
            // 
            labelControl25.Appearance.ForeColor = Color.Navy;
            labelControl25.Appearance.Options.UseForeColor = true;
            labelControl25.Location = new Point(39, 101);
            labelControl25.Margin = new Padding(3, 2, 3, 2);
            labelControl25.Name = "labelControl25";
            labelControl25.Size = new Size(44, 13);
            labelControl25.TabIndex = 80;
            labelControl25.Text = "Shipment";
            // 
            // txtShipmentName
            // 
            txtShipmentName.Location = new Point(129, 21);
            txtShipmentName.Margin = new Padding(3, 2, 3, 2);
            txtShipmentName.Name = "txtShipmentName";
            txtShipmentName.Size = new Size(305, 20);
            txtShipmentName.TabIndex = 0;
            // 
            // labelControl24
            // 
            labelControl24.Appearance.ForeColor = Color.Navy;
            labelControl24.Appearance.Options.UseForeColor = true;
            labelControl24.Location = new Point(39, 25);
            labelControl24.Margin = new Padding(3, 2, 3, 2);
            labelControl24.Name = "labelControl24";
            labelControl24.Size = new Size(81, 13);
            labelControl24.TabIndex = 79;
            labelControl24.Text = "Shipment Name :";
            // 
            // txtShipmentDescription
            // 
            txtShipmentDescription.Location = new Point(129, 89);
            txtShipmentDescription.Margin = new Padding(3, 2, 3, 2);
            txtShipmentDescription.Name = "txtShipmentDescription";
            txtShipmentDescription.Size = new Size(305, 80);
            txtShipmentDescription.TabIndex = 2;
            // 
            // ShipmentDate
            // 
            ShipmentDate.EditValue = null;
            ShipmentDate.Location = new Point(129, 177);
            ShipmentDate.Margin = new Padding(3, 2, 3, 2);
            ShipmentDate.Name = "ShipmentDate";
            ShipmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ShipmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ShipmentDate.Properties.DisplayFormat.FormatString = "";
            ShipmentDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            ShipmentDate.Properties.EditFormat.FormatString = "";
            ShipmentDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            ShipmentDate.Properties.MaskSettings.Set("mask", "");
            ShipmentDate.Size = new Size(305, 20);
            ShipmentDate.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.ForeColor = Color.Navy;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(39, 115);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(60, 13);
            labelControl1.TabIndex = 85;
            labelControl1.Text = "Description :";
            // 
            // lookUpEditPo
            // 
            lookUpEditPo.Location = new Point(129, 55);
            lookUpEditPo.Margin = new Padding(3, 2, 3, 2);
            lookUpEditPo.Name = "lookUpEditPo";
            lookUpEditPo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditPo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoId", "Po Id", 38, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrId", "Mr Id", 39, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoName", "Po Name", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoDescription", "Po Description", 82, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnteredDate", "Entered Date", 76, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEditPo.Properties.DisplayMember = "PoName";
            lookUpEditPo.Properties.NullText = "Select Po ...";
            lookUpEditPo.Properties.ValueMember = "PoId";
            lookUpEditPo.Size = new Size(306, 20);
            lookUpEditPo.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.ForeColor = Color.Navy;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(39, 59);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(21, 13);
            labelControl2.TabIndex = 88;
            labelControl2.Text = "PO :";
            // 
            // frmShipment
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 309);
            Controls.Add(labelControl2);
            Controls.Add(lookUpEditPo);
            Controls.Add(labelControl1);
            Controls.Add(lblIRNEnterDate);
            Controls.Add(progressBarControl1);
            Controls.Add(btnAddShipment);
            Controls.Add(labelControl26);
            Controls.Add(labelControl25);
            Controls.Add(txtShipmentName);
            Controls.Add(labelControl24);
            Controls.Add(txtShipmentDescription);
            Controls.Add(ShipmentDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("frmShipment.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmShipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Shipment";
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtShipmentName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtShipmentDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPo.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblIRNEnterDate;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddShipment;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit txtShipmentName;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.MemoEdit txtShipmentDescription;
        private DevExpress.XtraEditors.DateEdit ShipmentDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}