namespace AWMS.app.Forms.RibbonMaterial
{
    partial class frmMr
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
            DevExpress.XtraBars.Bar bar2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMr));
            ExcelExportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            DeleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            groupBox1 = new GroupBox();
            txtMrName = new DevExpress.XtraEditors.TextEdit();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            txtMrDescription = new DevExpress.XtraEditors.MemoEdit();
            lblpoName = new DevExpress.XtraEditors.LabelControl();
            lblMrDescirption = new DevExpress.XtraEditors.LabelControl();
            lblMrEnterDate = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            btnAddMr = new DevExpress.XtraEditors.SimpleButton();
            splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMrId = new DevExpress.XtraGrid.Columns.GridColumn();
            colMrName = new DevExpress.XtraGrid.Columns.GridColumn();
            colMrDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            barDockControl14 = new DevExpress.XtraBars.BarDockControl();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            barDockControl13 = new DevExpress.XtraBars.BarDockControl();
            bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMrName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMrDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel1).BeginInit();
            splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel2).BeginInit();
            splitContainerControl2.Panel2.SuspendLayout();
            splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // bar2
            // 
            bar2.AccessibleRole = AccessibleRole.None;
            bar2.BarName = "Custom 3";
            bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom | DevExpress.XtraBars.BarCanDockStyle.Standalone;
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            bar2.FloatLocation = new Point(341, 248);
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(ExcelExportBarButtonItem), new DevExpress.XtraBars.LinkPersistInfo(DeleteBarButtonItem) });
            bar2.OptionsBar.AllowQuickCustomization = false;
            bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            bar2.OptionsBar.DisableClose = true;
            bar2.OptionsBar.DistanceBetweenItems = 5;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.StandaloneBarDockControl = standaloneBarDockControl2;
            bar2.Text = "Custom 3";
            // 
            // ExcelExportBarButtonItem
            // 
            ExcelExportBarButtonItem.Caption = "Excel";
            ExcelExportBarButtonItem.Id = 0;
            ExcelExportBarButtonItem.ImageOptions.Image = Properties.Resources.exporttoxls_16x161;
            ExcelExportBarButtonItem.ImageOptions.LargeImage = Properties.Resources.exporttoxls_16x161;
            ExcelExportBarButtonItem.Name = "ExcelExportBarButtonItem";
            ExcelExportBarButtonItem.ItemClick += ExcelExportBarButtonItem_ItemClick;
            // 
            // DeleteBarButtonItem
            // 
            DeleteBarButtonItem.Caption = "delete";
            DeleteBarButtonItem.Id = 3;
            DeleteBarButtonItem.ImageOptions.Image = Properties.Resources.none_16x16;
            DeleteBarButtonItem.ImageOptions.LargeImage = Properties.Resources.none_16x16;
            DeleteBarButtonItem.Name = "DeleteBarButtonItem";
            DeleteBarButtonItem.ItemClick += DeleteBarButtonItem_ItemClick;
            // 
            // standaloneBarDockControl2
            // 
            standaloneBarDockControl2.AutoSize = true;
            standaloneBarDockControl2.CausesValidation = false;
            standaloneBarDockControl2.Dock = DockStyle.Top;
            standaloneBarDockControl2.Location = new Point(0, 0);
            standaloneBarDockControl2.Manager = barManager1;
            standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            standaloneBarDockControl2.Size = new Size(1022, 24);
            standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.DockControls.Add(standaloneBarDockControl2);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ExcelExportBarButtonItem, DeleteBarButtonItem });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1311, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 647);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1311, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 647);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1311, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 647);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 0);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            splitContainerControl1.Panel1.Controls.Add(groupBox1);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(progressBarControl1);
            splitContainerControl1.Panel1.Controls.Add(btnAddMr);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(splitContainerControl2);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1311, 647);
            splitContainerControl1.SplitterPosition = 279;
            splitContainerControl1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMrName);
            groupBox1.Controls.Add(dateEdit1);
            groupBox1.Controls.Add(txtMrDescription);
            groupBox1.Controls.Add(lblpoName);
            groupBox1.Controls.Add(lblMrDescirption);
            groupBox1.Controls.Add(lblMrEnterDate);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Location = new Point(10, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 225);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // txtMrName
            // 
            txtMrName.Location = new Point(99, 29);
            txtMrName.Name = "txtMrName";
            txtMrName.Size = new Size(141, 20);
            txtMrName.TabIndex = 0;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(99, 158);
            dateEdit1.MenuManager = barManager1;
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            dateEdit1.Size = new Size(141, 20);
            dateEdit1.TabIndex = 2;
            // 
            // txtMrDescription
            // 
            txtMrDescription.Location = new Point(99, 61);
            txtMrDescription.Name = "txtMrDescription";
            txtMrDescription.Size = new Size(141, 81);
            txtMrDescription.TabIndex = 1;
            // 
            // lblpoName
            // 
            lblpoName.Location = new Point(10, 32);
            lblpoName.Name = "lblpoName";
            lblpoName.Size = new Size(49, 13);
            lblpoName.TabIndex = 6;
            lblpoName.Text = "Mr Name :";
            // 
            // lblMrDescirption
            // 
            lblMrDescirption.Location = new Point(10, 66);
            lblMrDescirption.Name = "lblMrDescirption";
            lblMrDescirption.Size = new Size(75, 13);
            lblMrDescirption.TabIndex = 8;
            lblMrDescirption.Text = "Mr Description :";
            // 
            // lblMrEnterDate
            // 
            lblMrEnterDate.Appearance.ForeColor = Color.Silver;
            lblMrEnterDate.Appearance.Options.UseForeColor = true;
            lblMrEnterDate.Location = new Point(10, 193);
            lblMrEnterDate.Name = "lblMrEnterDate";
            lblMrEnterDate.Size = new Size(73, 13);
            lblMrEnterDate.TabIndex = 10;
            lblMrEnterDate.Text = "MrEnteredDate";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(10, 165);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(83, 13);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Mr EnteredDate :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.ForeColor = Color.Silver;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(10, 30);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(85, 12);
            labelControl3.TabIndex = 14;
            labelControl3.Text = "Material Request";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.LightCoral;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(10, 8);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(84, 17);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "Mr's Section";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(20, 352);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(225, 18);
            progressBarControl1.TabIndex = 0;
            // 
            // btnAddMr
            // 
            btnAddMr.ImageOptions.Image = (Image)resources.GetObject("btnAddMr.ImageOptions.Image");
            btnAddMr.Location = new Point(20, 300);
            btnAddMr.Name = "btnAddMr";
            btnAddMr.Size = new Size(225, 46);
            btnAddMr.TabIndex = 3;
            btnAddMr.Text = "&Add Mr";
            btnAddMr.ToolTip = "Alt+A To Add Mr";
            btnAddMr.Click += btnAddMr_Click;
            // 
            // splitContainerControl2
            // 
            splitContainerControl2.Dock = DockStyle.Fill;
            splitContainerControl2.Horizontal = false;
            splitContainerControl2.IsSplitterFixed = true;
            splitContainerControl2.Location = new Point(0, 0);
            splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            splitContainerControl2.Panel1.Controls.Add(standaloneBarDockControl2);
            splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            splitContainerControl2.Panel2.Controls.Add(gridControl1);
            splitContainerControl2.Panel2.Text = "Panel2";
            splitContainerControl2.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.False;
            splitContainerControl2.Size = new Size(1022, 647);
            splitContainerControl2.SplitterPosition = 25;
            splitContainerControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.MenuManager = barManager1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1022, 612);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMrId, colMrName, colMrDescription, colEnteredDate });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            // 
            // colMrId
            // 
            colMrId.Caption = "Mr Id";
            colMrId.FieldName = "MrId";
            colMrId.ImageOptions.Image = (Image)resources.GetObject("colMrId.ImageOptions.Image");
            colMrId.MinWidth = 21;
            colMrId.Name = "colMrId";
            colMrId.OptionsColumn.AllowEdit = false;
            colMrId.Visible = true;
            colMrId.VisibleIndex = 0;
            colMrId.Width = 64;
            // 
            // colMrName
            // 
            colMrName.Caption = "Mr Name";
            colMrName.FieldName = "MrName";
            colMrName.ImageOptions.Image = (Image)resources.GetObject("colMrName.ImageOptions.Image");
            colMrName.MinWidth = 21;
            colMrName.Name = "colMrName";
            colMrName.Visible = true;
            colMrName.VisibleIndex = 1;
            colMrName.Width = 291;
            // 
            // colMrDescription
            // 
            colMrDescription.AppearanceCell.Options.UseTextOptions = true;
            colMrDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colMrDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colMrDescription.Caption = "Mr Description";
            colMrDescription.FieldName = "MrDescription";
            colMrDescription.ImageOptions.Image = (Image)resources.GetObject("colMrDescription.ImageOptions.Image");
            colMrDescription.MinWidth = 21;
            colMrDescription.Name = "colMrDescription";
            colMrDescription.Visible = true;
            colMrDescription.VisibleIndex = 2;
            colMrDescription.Width = 481;
            // 
            // colEnteredDate
            // 
            colEnteredDate.Caption = "EnteredDate";
            colEnteredDate.FieldName = "EnteredDate";
            colEnteredDate.ImageOptions.Image = (Image)resources.GetObject("colEnteredDate.ImageOptions.Image");
            colEnteredDate.MinWidth = 21;
            colEnteredDate.Name = "colEnteredDate";
            colEnteredDate.Visible = true;
            colEnteredDate.VisibleIndex = 3;
            colEnteredDate.Width = 189;
            // 
            // barDockControl14
            // 
            barDockControl14.CausesValidation = false;
            barDockControl14.Dock = DockStyle.Left;
            barDockControl14.Location = new Point(0, 0);
            barDockControl14.Manager = null;
            barDockControl14.Size = new Size(0, 647);
            // 
            // ribbonPage2
            // 
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ribbonPage2";
            // 
            // barDockControl13
            // 
            barDockControl13.CausesValidation = false;
            barDockControl13.Dock = DockStyle.Right;
            barDockControl13.Location = new Point(1311, 0);
            barDockControl13.Manager = null;
            barDockControl13.Size = new Size(0, 647);
            // 
            // frmMr
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 647);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControl14);
            Controls.Add(barDockControl13);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmMr";
            Text = "Mr";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMrName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMrDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel1).EndInit();
            splitContainerControl2.Panel1.ResumeLayout(false);
            splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2.Panel2).EndInit();
            splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl2).EndInit();
            splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControl14;
        private DevExpress.XtraBars.BarDockControl barDockControl13;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.MemoEdit txtMrDescription;
        private DevExpress.XtraEditors.SimpleButton btnAddMr;
        private DevExpress.XtraEditors.LabelControl lblMrDescirption;
        private DevExpress.XtraEditors.TextEdit txtMrName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblMrEnterDate;
        private DevExpress.XtraEditors.LabelControl lblpoName;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private GroupBox groupBox1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMrId;
        private DevExpress.XtraGrid.Columns.GridColumn colMrName;
        private DevExpress.XtraGrid.Columns.GridColumn colMrDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredDate;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem ExcelExportBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem DeleteBarButtonItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}