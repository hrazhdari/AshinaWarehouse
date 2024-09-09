namespace AWMS.app.Forms.RibbonMaterial
{
    partial class frmImportPackingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportPackingList));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPK = new DevExpress.XtraGrid.Columns.GridColumn();
            colNetW = new DevExpress.XtraGrid.Columns.GridColumn();
            colGrossW = new DevExpress.XtraGrid.Columns.GridColumn();
            colDimension = new DevExpress.XtraGrid.Columns.GridColumn();
            colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            colArrivalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDesciption = new DevExpress.XtraGrid.Columns.GridColumn();
            colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colEditedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colEditedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnImport = new DevExpress.XtraEditors.SimpleButton();
            panelControl5 = new DevExpress.XtraEditors.PanelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            btnRefreshArchiveNO = new DevExpress.XtraEditors.SimpleButton();
            btnAddIrn = new DevExpress.XtraEditors.SimpleButton();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            chkEdit = new DevExpress.XtraEditors.CheckEdit();
            lookUpEditLocation = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            lookUpEditPL = new DevExpress.XtraEditors.LookUpEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl5).BeginInit();
            panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditLocation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPL.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(panelControl3);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(919, 450);
            panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(gridControl1);
            panelControl3.Dock = DockStyle.Fill;
            panelControl3.Location = new Point(2, 93);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(915, 355);
            panelControl3.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(911, 351);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPK, colNetW, colGrossW, colDimension, colVolume, colArrivalDate, colDesciption, colRemark, colEnteredBy, colEnteredDate, colEditedBy, colEditedDate });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colPK
            // 
            colPK.FieldName = "PK";
            colPK.MinWidth = 21;
            colPK.Name = "colPK";
            colPK.Visible = true;
            colPK.VisibleIndex = 0;
            colPK.Width = 77;
            // 
            // colNetW
            // 
            colNetW.FieldName = "NetW";
            colNetW.MinWidth = 21;
            colNetW.Name = "colNetW";
            colNetW.Visible = true;
            colNetW.VisibleIndex = 1;
            colNetW.Width = 161;
            // 
            // colGrossW
            // 
            colGrossW.FieldName = "GrossW";
            colGrossW.MinWidth = 21;
            colGrossW.Name = "colGrossW";
            colGrossW.Visible = true;
            colGrossW.VisibleIndex = 2;
            colGrossW.Width = 161;
            // 
            // colDimension
            // 
            colDimension.FieldName = "Dimension";
            colDimension.MinWidth = 21;
            colDimension.Name = "colDimension";
            colDimension.Visible = true;
            colDimension.VisibleIndex = 3;
            colDimension.Width = 161;
            // 
            // colVolume
            // 
            colVolume.FieldName = "Volume";
            colVolume.MinWidth = 21;
            colVolume.Name = "colVolume";
            colVolume.Visible = true;
            colVolume.VisibleIndex = 4;
            colVolume.Width = 67;
            // 
            // colArrivalDate
            // 
            colArrivalDate.FieldName = "ArrivalDate";
            colArrivalDate.MinWidth = 21;
            colArrivalDate.Name = "colArrivalDate";
            colArrivalDate.Visible = true;
            colArrivalDate.VisibleIndex = 5;
            colArrivalDate.Width = 184;
            // 
            // colDesciption
            // 
            colDesciption.FieldName = "Desciption";
            colDesciption.MinWidth = 21;
            colDesciption.Name = "colDesciption";
            colDesciption.Visible = true;
            colDesciption.VisibleIndex = 6;
            colDesciption.Width = 376;
            // 
            // colRemark
            // 
            colRemark.FieldName = "Remark";
            colRemark.MinWidth = 21;
            colRemark.Name = "colRemark";
            colRemark.Visible = true;
            colRemark.VisibleIndex = 7;
            colRemark.Width = 152;
            // 
            // colEnteredBy
            // 
            colEnteredBy.FieldName = "EnteredBy";
            colEnteredBy.MinWidth = 21;
            colEnteredBy.Name = "colEnteredBy";
            colEnteredBy.Width = 92;
            // 
            // colEnteredDate
            // 
            colEnteredDate.FieldName = "EnteredDate";
            colEnteredDate.MinWidth = 21;
            colEnteredDate.Name = "colEnteredDate";
            colEnteredDate.Width = 92;
            // 
            // colEditedBy
            // 
            colEditedBy.FieldName = "EditedBy";
            colEditedBy.MinWidth = 21;
            colEditedBy.Name = "colEditedBy";
            colEditedBy.Width = 92;
            // 
            // colEditedDate
            // 
            colEditedDate.FieldName = "EditedDate";
            colEditedDate.MinWidth = 21;
            colEditedDate.Name = "colEditedDate";
            colEditedDate.OptionsColumn.ReadOnly = true;
            colEditedDate.Width = 104;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnDelete);
            panelControl2.Controls.Add(btnImport);
            panelControl2.Controls.Add(panelControl5);
            panelControl2.Controls.Add(panelControl4);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(915, 91);
            panelControl2.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.Location = new Point(789, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete PK";
            // 
            // btnImport
            // 
            btnImport.ImageOptions.Image = (Image)resources.GetObject("btnImport.ImageOptions.Image");
            btnImport.Location = new Point(710, 52);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 6;
            btnImport.Text = "Import";
            btnImport.Click += btnImport_Click;
            // 
            // panelControl5
            // 
            panelControl5.Appearance.BackColor = Color.Honeydew;
            panelControl5.Appearance.Options.UseBackColor = true;
            panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl5.Controls.Add(labelControl4);
            panelControl5.Controls.Add(btnRefreshArchiveNO);
            panelControl5.Controls.Add(btnAddIrn);
            panelControl5.Location = new Point(15, 46);
            panelControl5.Name = "panelControl5";
            panelControl5.Size = new Size(279, 35);
            panelControl5.TabIndex = 5;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BackColor = Color.LimeGreen;
            labelControl4.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.ForeColor = Color.Transparent;
            labelControl4.Appearance.Options.UseBackColor = true;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.LineColor = Color.FromArgb(255, 128, 0);
            labelControl4.Location = new Point(38, 10);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(80, 14);
            labelControl4.TabIndex = 135;
            labelControl4.Text = "Refresh Data";
            labelControl4.Click += labelControl4_Click;
            // 
            // btnRefreshArchiveNO
            // 
            btnRefreshArchiveNO.ImageOptions.Image = (Image)resources.GetObject("btnRefreshArchiveNO.ImageOptions.Image");
            btnRefreshArchiveNO.Location = new Point(13, 8);
            btnRefreshArchiveNO.Name = "btnRefreshArchiveNO";
            btnRefreshArchiveNO.Size = new Size(21, 19);
            btnRefreshArchiveNO.TabIndex = 134;
            btnRefreshArchiveNO.Click += btnRefreshArchiveNO_Click;
            // 
            // btnAddIrn
            // 
            btnAddIrn.ImageOptions.Image = (Image)resources.GetObject("btnAddIrn.ImageOptions.Image");
            btnAddIrn.Location = new Point(160, 6);
            btnAddIrn.Name = "btnAddIrn";
            btnAddIrn.Size = new Size(108, 23);
            btnAddIrn.TabIndex = 8;
            btnAddIrn.Text = "Insert Location";
            btnAddIrn.Click += btnAddIrn_Click;
            // 
            // panelControl4
            // 
            panelControl4.Appearance.BackColor = Color.Linen;
            panelControl4.Appearance.Options.UseBackColor = true;
            panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl4.Controls.Add(labelControl3);
            panelControl4.Controls.Add(chkEdit);
            panelControl4.Controls.Add(lookUpEditLocation);
            panelControl4.Controls.Add(labelControl2);
            panelControl4.Controls.Add(lookUpEditPL);
            panelControl4.Controls.Add(labelControl1);
            panelControl4.Location = new Point(15, 10);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new Size(851, 31);
            panelControl4.TabIndex = 4;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl3.ImageOptions.Image = (Image)resources.GetObject("labelControl3.ImageOptions.Image");
            labelControl3.Location = new Point(758, 6);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(21, 20);
            labelControl3.TabIndex = 90;
            // 
            // chkEdit
            // 
            chkEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEdit.Location = new Point(781, 6);
            chkEdit.Name = "chkEdit";
            chkEdit.Properties.Caption = "Load All";
            chkEdit.Size = new Size(61, 20);
            chkEdit.TabIndex = 89;
            chkEdit.CheckedChanged += chkEdit_CheckedChanged;
            // 
            // lookUpEditLocation
            // 
            lookUpEditLocation.Location = new Point(69, 6);
            lookUpEditLocation.Name = "lookUpEditLocation";
            lookUpEditLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditLocation.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 67, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEditLocation.Properties.DisplayMember = "LocationName";
            lookUpEditLocation.Properties.NullText = "Select Location ...";
            lookUpEditLocation.Properties.ValueMember = "LocationID";
            lookUpEditLocation.Size = new Size(245, 20);
            lookUpEditLocation.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(14, 10);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(47, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Location :";
            // 
            // lookUpEditPL
            // 
            lookUpEditPL.Location = new Point(404, 6);
            lookUpEditPL.Name = "lookUpEditPL";
            lookUpEditPL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditPL.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PLId", "PLId", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PLName", "", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEditPL.Properties.DisplayMember = "PLName";
            lookUpEditPL.Properties.NullText = "Select PackingList ...";
            lookUpEditPL.Properties.ValueMember = "PLId";
            lookUpEditPL.Size = new Size(316, 20);
            lookUpEditPL.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(334, 10);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(62, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Packing List :";
            // 
            // frmImportPackingList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = Properties.Resources.exporttoxls_16x164;
            MaximizeBox = false;
            Name = "frmImportPackingList";
            Text = "Import Packing List";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl5).EndInit();
            panelControl5.ResumeLayout(false);
            panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditLocation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPL.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPL;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLocation;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnRefreshArchiveNO;
        private DevExpress.XtraEditors.SimpleButton btnAddIrn;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colPK;
        private DevExpress.XtraGrid.Columns.GridColumn colNetW;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossW;
        private DevExpress.XtraGrid.Columns.GridColumn colDimension;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colArrivalDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDesciption;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredBy;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEditedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colEditedDate;
    }
}