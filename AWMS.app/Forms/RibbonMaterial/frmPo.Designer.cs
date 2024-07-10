namespace AWMS.app.Forms.RibbonMaterial
{
    partial class frmPo
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
            components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPo));
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            txtPoDescription = new DevExpress.XtraEditors.MemoEdit();
            btnAddPo = new DevExpress.XtraEditors.SimpleButton();
            txtPoName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblPoEnterDate = new DevExpress.XtraEditors.LabelControl();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            lblMrDescirption = new DevExpress.XtraEditors.LabelControl();
            lblpoName = new DevExpress.XtraEditors.LabelControl();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPoId = new DevExpress.XtraGrid.Columns.GridColumn();
            colMrId = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colPoName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPoDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPoDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPoName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.ForeColor = Color.Silver;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(10, 28);
            labelControl3.Margin = new Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(79, 12);
            labelControl3.TabIndex = 14;
            labelControl3.Text = "Purchase Order";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Margin = new Padding(3, 2, 3, 2);
            barDockControlTop.Size = new Size(1237, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 546);
            barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new Size(1237, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new Size(0, 546);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1237, 0);
            barDockControlRight.Margin = new Padding(3, 2, 3, 2);
            barDockControlRight.Size = new Size(0, 546);
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.LightCoral;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(10, 8);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(84, 17);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "Po's Section";
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(97, 179);
            dateEdit1.Margin = new Padding(3, 2, 3, 2);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            dateEdit1.Size = new Size(141, 20);
            dateEdit1.TabIndex = 2;
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(18, 350);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(230, 16);
            progressBarControl1.TabIndex = 0;
            // 
            // txtPoDescription
            // 
            txtPoDescription.Location = new Point(97, 49);
            txtPoDescription.Margin = new Padding(3, 2, 3, 2);
            txtPoDescription.Name = "txtPoDescription";
            txtPoDescription.Size = new Size(141, 74);
            txtPoDescription.TabIndex = 1;
            // 
            // btnAddPo
            // 
            btnAddPo.ImageOptions.Image = (Image)resources.GetObject("btnAddPo.ImageOptions.Image");
            btnAddPo.Location = new Point(18, 302);
            btnAddPo.Margin = new Padding(3, 2, 3, 2);
            btnAddPo.Name = "btnAddPo";
            btnAddPo.Size = new Size(230, 43);
            btnAddPo.TabIndex = 3;
            btnAddPo.Text = "&Add Po";
            btnAddPo.ToolTip = "Alt+A To Add Mr";
            btnAddPo.Click += btnAddPo_Click;
            // 
            // txtPoName
            // 
            txtPoName.Location = new Point(97, 19);
            txtPoName.Margin = new Padding(3, 2, 3, 2);
            txtPoName.Name = "txtPoName";
            txtPoName.Size = new Size(141, 20);
            txtPoName.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(8, 186);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(83, 13);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Po EnteredDate :";
            // 
            // lblPoEnterDate
            // 
            lblPoEnterDate.Appearance.ForeColor = Color.Silver;
            lblPoEnterDate.Appearance.Options.UseForeColor = true;
            lblPoEnterDate.Location = new Point(8, 212);
            lblPoEnterDate.Margin = new Padding(3, 2, 3, 2);
            lblPoEnterDate.Name = "lblPoEnterDate";
            lblPoEnterDate.Size = new Size(73, 13);
            lblPoEnterDate.TabIndex = 10;
            lblPoEnterDate.Text = "PoEnteredDate";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ribbonPage2";
            // 
            // lblMrDescirption
            // 
            lblMrDescirption.Location = new Point(8, 53);
            lblMrDescirption.Margin = new Padding(3, 2, 3, 2);
            lblMrDescirption.Name = "lblMrDescirption";
            lblMrDescirption.Size = new Size(75, 13);
            lblMrDescirption.TabIndex = 8;
            lblMrDescirption.Text = "Po Description :";
            // 
            // lblpoName
            // 
            lblpoName.Location = new Point(8, 22);
            lblpoName.Margin = new Padding(3, 2, 3, 2);
            lblpoName.Name = "lblpoName";
            lblpoName.Size = new Size(49, 13);
            lblpoName.TabIndex = 6;
            lblpoName.Text = "Po Name :";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 0);
            splitContainerControl1.Margin = new Padding(3, 2, 3, 2);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            splitContainerControl1.Panel1.Controls.Add(groupBox1);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(progressBarControl1);
            splitContainerControl1.Panel1.Controls.Add(btnAddPo);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gridControl1);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1237, 546);
            splitContainerControl1.SplitterPosition = 279;
            splitContainerControl1.TabIndex = 43;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(97, 140);
            lookUpEdit1.Margin = new Padding(3, 2, 3, 2);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrId", "Mr Id", 43, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrName", "Mr Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrDescription", "Mr Description", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnteredDate", "Entered Date", 81, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pos", "Pos", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEdit1.Properties.DisplayMember = "MrName";
            lookUpEdit1.Properties.NullText = "Select Mr ...";
            lookUpEdit1.Properties.ValueMember = "MrId";
            lookUpEdit1.Size = new Size(141, 20);
            lookUpEdit1.TabIndex = 16;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(8, 147);
            labelControl4.Margin = new Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(19, 13);
            labelControl4.TabIndex = 15;
            labelControl4.Text = "Mr :";
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEdit1 });
            gridControl1.Size = new Size(948, 546);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPoId, colMrId, colPoName, colPoDescription, colEnteredDate });
            gridView1.DetailHeight = 262;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.RowStyle += gridView1_RowStyle;
            // 
            // colPoId
            // 
            colPoId.FieldName = "PoId";
            colPoId.ImageOptions.Image = (Image)resources.GetObject("colPoId.ImageOptions.Image");
            colPoId.MinWidth = 21;
            colPoId.Name = "colPoId";
            colPoId.OptionsColumn.AllowEdit = false;
            colPoId.Visible = true;
            colPoId.VisibleIndex = 0;
            colPoId.Width = 107;
            // 
            // colMrId
            // 
            colMrId.Caption = "Mr Name";
            colMrId.ColumnEdit = repositoryItemLookUpEdit1;
            colMrId.FieldName = "MrId";
            colMrId.ImageOptions.Image = (Image)resources.GetObject("colMrId.ImageOptions.Image");
            colMrId.MinWidth = 21;
            colMrId.Name = "colMrId";
            colMrId.Visible = true;
            colMrId.VisibleIndex = 1;
            colMrId.Width = 217;
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrId", "Mr Id", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrName", "Mr Name", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEdit1.DisplayMember = "MrName";
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            repositoryItemLookUpEdit1.ValueMember = "MrId";
            // 
            // colPoName
            // 
            colPoName.FieldName = "PoName";
            colPoName.ImageOptions.Image = (Image)resources.GetObject("colPoName.ImageOptions.Image");
            colPoName.MinWidth = 21;
            colPoName.Name = "colPoName";
            colPoName.Visible = true;
            colPoName.VisibleIndex = 2;
            colPoName.Width = 214;
            // 
            // colPoDescription
            // 
            colPoDescription.AppearanceCell.Options.UseTextOptions = true;
            colPoDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colPoDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colPoDescription.FieldName = "PoDescription";
            colPoDescription.ImageOptions.Image = (Image)resources.GetObject("colPoDescription.ImageOptions.Image");
            colPoDescription.MinWidth = 21;
            colPoDescription.Name = "colPoDescription";
            colPoDescription.Visible = true;
            colPoDescription.VisibleIndex = 3;
            colPoDescription.Width = 261;
            // 
            // colEnteredDate
            // 
            colEnteredDate.FieldName = "EnteredDate";
            colEnteredDate.ImageOptions.Image = (Image)resources.GetObject("colEnteredDate.ImageOptions.Image");
            colEnteredDate.MinWidth = 21;
            colEnteredDate.Name = "colEnteredDate";
            colEnteredDate.Visible = true;
            colEnteredDate.VisibleIndex = 4;
            colEnteredDate.Width = 261;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPoDescription);
            groupBox1.Controls.Add(lookUpEdit1);
            groupBox1.Controls.Add(lblpoName);
            groupBox1.Controls.Add(labelControl4);
            groupBox1.Controls.Add(lblPoEnterDate);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(txtPoName);
            groupBox1.Controls.Add(dateEdit1);
            groupBox1.Controls.Add(lblMrDescirption);
            groupBox1.Location = new Point(10, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 249);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // frmPo
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 546);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmPo";
            Text = "Po";
            FormClosed += frmPo_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPoDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPoName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.MemoEdit txtPoDescription;
        private DevExpress.XtraEditors.SimpleButton btnAddPo;
        private DevExpress.XtraEditors.LabelControl lblMrDescirption;
        private DevExpress.XtraEditors.TextEdit txtPoName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPoEnterDate;
        private DevExpress.XtraEditors.LabelControl lblpoName;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPoId;
        private DevExpress.XtraGrid.Columns.GridColumn colMrId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPoName;
        private DevExpress.XtraGrid.Columns.GridColumn colPoDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private GroupBox groupBox1;
    }
}