namespace AWMS.app.Forms.frmSmall
{
    partial class frmAreaUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreaUnit));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblAreaEnterDate = new DevExpress.XtraEditors.LabelControl();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            labelControl26 = new DevExpress.XtraEditors.LabelControl();
            txtAreaName = new DevExpress.XtraEditors.TextEdit();
            labelControl24 = new DevExpress.XtraEditors.LabelControl();
            txtAreaDescription = new DevExpress.XtraEditors.MemoEdit();
            AreaDate = new DevExpress.XtraEditors.DateEdit();
            btnAddAreaUnit = new DevExpress.XtraEditors.SimpleButton();
            labelControl25 = new DevExpress.XtraEditors.LabelControl();
            txtAreaTrain = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtAreaRemark = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AreaDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AreaDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaTrain.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaRemark.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.ForeColor = Color.Navy;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(33, 110);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(60, 13);
            labelControl1.TabIndex = 98;
            labelControl1.Text = "Description :";
            // 
            // lblAreaEnterDate
            // 
            lblAreaEnterDate.Appearance.ForeColor = Color.DarkGray;
            lblAreaEnterDate.Appearance.Options.UseForeColor = true;
            lblAreaEnterDate.Location = new Point(123, 296);
            lblAreaEnterDate.Margin = new Padding(3, 2, 3, 2);
            lblAreaEnterDate.Name = "lblAreaEnterDate";
            lblAreaEnterDate.Size = new Size(20, 13);
            lblAreaEnterDate.TabIndex = 97;
            lblAreaEnterDate.Text = ".....";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(122, 371);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(305, 18);
            progressBarControl1.TabIndex = 96;
            // 
            // labelControl26
            // 
            labelControl26.Appearance.ForeColor = Color.Navy;
            labelControl26.Appearance.Options.UseForeColor = true;
            labelControl26.Location = new Point(33, 277);
            labelControl26.Margin = new Padding(3, 2, 3, 2);
            labelControl26.Name = "labelControl26";
            labelControl26.Size = new Size(30, 13);
            labelControl26.TabIndex = 94;
            labelControl26.Text = "Date :";
            // 
            // txtAreaName
            // 
            txtAreaName.Location = new Point(123, 17);
            txtAreaName.Margin = new Padding(3, 2, 3, 2);
            txtAreaName.Name = "txtAreaName";
            txtAreaName.Size = new Size(305, 20);
            txtAreaName.TabIndex = 0;
            // 
            // labelControl24
            // 
            labelControl24.Appearance.ForeColor = Color.Navy;
            labelControl24.Appearance.Options.UseForeColor = true;
            labelControl24.Location = new Point(32, 21);
            labelControl24.Margin = new Padding(3, 2, 3, 2);
            labelControl24.Name = "labelControl24";
            labelControl24.Size = new Size(82, 13);
            labelControl24.TabIndex = 92;
            labelControl24.Text = "Area Unit Name :";
            // 
            // txtAreaDescription
            // 
            txtAreaDescription.Location = new Point(123, 85);
            txtAreaDescription.Margin = new Padding(3, 2, 3, 2);
            txtAreaDescription.Name = "txtAreaDescription";
            txtAreaDescription.Size = new Size(305, 80);
            txtAreaDescription.TabIndex = 2;
            // 
            // AreaDate
            // 
            AreaDate.EditValue = null;
            AreaDate.Location = new Point(123, 273);
            AreaDate.Margin = new Padding(3, 2, 3, 2);
            AreaDate.Name = "AreaDate";
            AreaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            AreaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            AreaDate.Properties.DisplayFormat.FormatString = "";
            AreaDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            AreaDate.Properties.EditFormat.FormatString = "";
            AreaDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            AreaDate.Properties.MaskSettings.Set("mask", "");
            AreaDate.Size = new Size(305, 20);
            AreaDate.TabIndex = 4;
            // 
            // btnAddAreaUnit
            // 
            btnAddAreaUnit.ImageOptions.Image = (Image)resources.GetObject("btnAddAreaUnit.ImageOptions.Image");
            btnAddAreaUnit.Location = new Point(122, 321);
            btnAddAreaUnit.Margin = new Padding(3, 2, 3, 2);
            btnAddAreaUnit.Name = "btnAddAreaUnit";
            btnAddAreaUnit.Size = new Size(305, 46);
            btnAddAreaUnit.TabIndex = 5;
            btnAddAreaUnit.Text = "&Add Area Unit";
            btnAddAreaUnit.ToolTip = "Alt+A To Add Mr";
            btnAddAreaUnit.Click += btnAddAreaUnit_Click;
            // 
            // labelControl25
            // 
            labelControl25.Appearance.ForeColor = Color.Navy;
            labelControl25.Appearance.Options.UseForeColor = true;
            labelControl25.Location = new Point(33, 97);
            labelControl25.Margin = new Padding(3, 2, 3, 2);
            labelControl25.Name = "labelControl25";
            labelControl25.Size = new Size(45, 13);
            labelControl25.TabIndex = 93;
            labelControl25.Text = "Area Unit";
            // 
            // txtAreaTrain
            // 
            txtAreaTrain.Location = new Point(122, 50);
            txtAreaTrain.Margin = new Padding(3, 2, 3, 2);
            txtAreaTrain.Name = "txtAreaTrain";
            txtAreaTrain.Size = new Size(305, 20);
            txtAreaTrain.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.ForeColor = Color.Navy;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(31, 54);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(79, 13);
            labelControl2.TabIndex = 100;
            labelControl2.Text = "Area Unit Train :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.ForeColor = Color.Navy;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(32, 201);
            labelControl3.Margin = new Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(43, 13);
            labelControl3.TabIndex = 103;
            labelControl3.Text = "Remark :";
            // 
            // txtAreaRemark
            // 
            txtAreaRemark.Location = new Point(122, 176);
            txtAreaRemark.Margin = new Padding(3, 2, 3, 2);
            txtAreaRemark.Name = "txtAreaRemark";
            txtAreaRemark.Size = new Size(305, 80);
            txtAreaRemark.TabIndex = 3;
            // 
            // frmAreaUnit
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 406);
            Controls.Add(labelControl3);
            Controls.Add(txtAreaRemark);
            Controls.Add(txtAreaTrain);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(lblAreaEnterDate);
            Controls.Add(progressBarControl1);
            Controls.Add(btnAddAreaUnit);
            Controls.Add(labelControl26);
            Controls.Add(labelControl25);
            Controls.Add(txtAreaName);
            Controls.Add(labelControl24);
            Controls.Add(txtAreaDescription);
            Controls.Add(AreaDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("frmAreaUnit.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAreaUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add AreaUnit";
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AreaDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AreaDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaTrain.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAreaRemark.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblAreaEnterDate;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtAreaName;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.MemoEdit txtAreaDescription;
        private DevExpress.XtraEditors.DateEdit AreaDate;
        private DevExpress.XtraEditors.SimpleButton btnAddAreaUnit;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit txtAreaTrain;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtAreaRemark;
    }
}