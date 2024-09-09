namespace AWMS.app.Forms.RibbonSearch
{
    partial class frmSearchItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchItem));
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ReserveMivQty = new DevExpress.XtraGrid.Columns.GridColumn();
            DelMivQty = new DevExpress.XtraGrid.Columns.GridColumn();
            ReturnQty = new DevExpress.XtraGrid.Columns.GridColumn();
            TotalReturnAcceptQty = new DevExpress.XtraGrid.Columns.GridColumn();
            Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            Inventory = new DevExpress.XtraGrid.Columns.GridColumn();
            RejectQty = new DevExpress.XtraGrid.Columns.GridColumn();
            NISQty = new DevExpress.XtraGrid.Columns.GridColumn();
            Descipline = new DevExpress.XtraGrid.Columns.GridColumn();
            Scope = new DevExpress.XtraGrid.Columns.GridColumn();
            QtyinLocWithMRV = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEditirn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemLookUpEditpo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemLookUpEditmr = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemLookUpEditsupplier = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemLookUpEditscope = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemLookUpEditdescipline = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repositoryItemTextEditirn = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnRefreshArchiveNO = new DevExpress.XtraEditors.SimpleButton();
            ReqMivQty = new DevExpress.XtraGrid.Columns.GridColumn();
            QtyinLoc = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            RowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ArrivalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            MSRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            PLNO = new DevExpress.XtraGrid.Columns.GridColumn();
            OPINO = new DevExpress.XtraGrid.Columns.GridColumn();
            Project = new DevExpress.XtraGrid.Columns.GridColumn();
            EnteredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            MARDate = new DevExpress.XtraGrid.Columns.GridColumn();
            Po = new DevExpress.XtraGrid.Columns.GridColumn();
            Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            Vendor = new DevExpress.XtraGrid.Columns.GridColumn();
            Mr = new DevExpress.XtraGrid.Columns.GridColumn();
            IRN = new DevExpress.XtraGrid.Columns.GridColumn();
            ItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            PLName = new DevExpress.XtraGrid.Columns.GridColumn();
            ArchiveNO = new DevExpress.XtraGrid.Columns.GridColumn();
            PK = new DevExpress.XtraGrid.Columns.GridColumn();
            Tag = new DevExpress.XtraGrid.Columns.GridColumn();
            Description = new DevExpress.XtraGrid.Columns.GridColumn();
            Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            QtyPL = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            progressLabel = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditirn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditpo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditmr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditsupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditscope).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditdescipline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEditirn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl4.Appearance.BackColor = Color.LimeGreen;
            labelControl4.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.ForeColor = Color.Transparent;
            labelControl4.Appearance.Options.UseBackColor = true;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.LineColor = Color.FromArgb(255, 128, 0);
            labelControl4.Location = new Point(828, 10);
            labelControl4.Margin = new Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(80, 14);
            labelControl4.TabIndex = 140;
            labelControl4.Text = "Refresh Data";
            labelControl4.Click += labelControl4_Click_1;
            // 
            // ReserveMivQty
            // 
            ReserveMivQty.Caption = "Reserve MivQty";
            ReserveMivQty.FieldName = "ReserveMivQty";
            ReserveMivQty.MinWidth = 21;
            ReserveMivQty.Name = "ReserveMivQty";
            ReserveMivQty.Visible = true;
            ReserveMivQty.VisibleIndex = 13;
            ReserveMivQty.Width = 81;
            // 
            // DelMivQty
            // 
            DelMivQty.Caption = "Del MivQty";
            DelMivQty.FieldName = "DelMivQty";
            DelMivQty.MinWidth = 21;
            DelMivQty.Name = "DelMivQty";
            DelMivQty.Visible = true;
            DelMivQty.VisibleIndex = 14;
            DelMivQty.Width = 81;
            // 
            // ReturnQty
            // 
            ReturnQty.Caption = "Return Qty";
            ReturnQty.FieldName = "ReturnQty";
            ReturnQty.MinWidth = 21;
            ReturnQty.Name = "ReturnQty";
            ReturnQty.Width = 81;
            // 
            // TotalReturnAcceptQty
            // 
            TotalReturnAcceptQty.Caption = "Return AcceptQty";
            TotalReturnAcceptQty.FieldName = "TotalReturnAcceptQty";
            TotalReturnAcceptQty.MinWidth = 21;
            TotalReturnAcceptQty.Name = "TotalReturnAcceptQty";
            TotalReturnAcceptQty.Visible = true;
            TotalReturnAcceptQty.VisibleIndex = 9;
            TotalReturnAcceptQty.Width = 81;
            // 
            // Balance
            // 
            Balance.Caption = "Balance";
            Balance.FieldName = "Balance";
            Balance.MinWidth = 21;
            Balance.Name = "Balance";
            Balance.Visible = true;
            Balance.VisibleIndex = 15;
            Balance.Width = 81;
            // 
            // Inventory
            // 
            Inventory.Caption = "Inventory";
            Inventory.FieldName = "Inventory";
            Inventory.MinWidth = 21;
            Inventory.Name = "Inventory";
            Inventory.Visible = true;
            Inventory.VisibleIndex = 16;
            Inventory.Width = 81;
            // 
            // RejectQty
            // 
            RejectQty.Caption = "RejectQty";
            RejectQty.FieldName = "RejectQty";
            RejectQty.MinWidth = 21;
            RejectQty.Name = "RejectQty";
            RejectQty.Visible = true;
            RejectQty.VisibleIndex = 12;
            RejectQty.Width = 81;
            // 
            // NISQty
            // 
            NISQty.Caption = "NISQty";
            NISQty.FieldName = "NISQty";
            NISQty.MinWidth = 21;
            NISQty.Name = "NISQty";
            NISQty.Visible = true;
            NISQty.VisibleIndex = 11;
            NISQty.Width = 81;
            // 
            // Descipline
            // 
            Descipline.Caption = "Descipline";
            Descipline.FieldName = "Descipline";
            Descipline.MinWidth = 21;
            Descipline.Name = "Descipline";
            Descipline.Visible = true;
            Descipline.VisibleIndex = 17;
            Descipline.Width = 127;
            // 
            // Scope
            // 
            Scope.Caption = "Scope";
            Scope.FieldName = "Scope";
            Scope.MinWidth = 21;
            Scope.Name = "Scope";
            Scope.Visible = true;
            Scope.VisibleIndex = 18;
            Scope.Width = 144;
            // 
            // QtyinLocWithMRV
            // 
            QtyinLocWithMRV.Caption = "QtyinLoc With MRV";
            QtyinLocWithMRV.FieldName = "QtyinLocWithMRV";
            QtyinLocWithMRV.MinWidth = 21;
            QtyinLocWithMRV.Name = "QtyinLocWithMRV";
            QtyinLocWithMRV.Visible = true;
            QtyinLocWithMRV.VisibleIndex = 10;
            QtyinLocWithMRV.Width = 81;
            // 
            // repositoryItemLookUpEditirn
            // 
            repositoryItemLookUpEditirn.AutoHeight = false;
            repositoryItemLookUpEditirn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditirn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IrnId", "Irn Id", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IrnName", "Irn Name", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditirn.DisplayMember = "IrnName";
            repositoryItemLookUpEditirn.Name = "repositoryItemLookUpEditirn";
            repositoryItemLookUpEditirn.ValueMember = "IrnId";
            // 
            // repositoryItemLookUpEditpo
            // 
            repositoryItemLookUpEditpo.AutoHeight = false;
            repositoryItemLookUpEditpo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditpo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoId", "Po Id", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoName", "Po Name", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditpo.DisplayMember = "PoName";
            repositoryItemLookUpEditpo.Name = "repositoryItemLookUpEditpo";
            repositoryItemLookUpEditpo.ValueMember = "PoId";
            // 
            // repositoryItemLookUpEditmr
            // 
            repositoryItemLookUpEditmr.AutoHeight = false;
            repositoryItemLookUpEditmr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditmr.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrId", "MrId", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrName", "MrName", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditmr.DisplayMember = "MrName";
            repositoryItemLookUpEditmr.Name = "repositoryItemLookUpEditmr";
            repositoryItemLookUpEditmr.ValueMember = "MrId";
            // 
            // repositoryItemLookUpEditsupplier
            // 
            repositoryItemLookUpEditsupplier.AutoHeight = false;
            repositoryItemLookUpEditsupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditsupplier.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierId", "Supplier Id", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "SupplierName", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditsupplier.DisplayMember = "SupplierName";
            repositoryItemLookUpEditsupplier.Name = "repositoryItemLookUpEditsupplier";
            repositoryItemLookUpEditsupplier.ValueMember = "SupplierId";
            // 
            // repositoryItemLookUpEditscope
            // 
            repositoryItemLookUpEditscope.AutoHeight = false;
            repositoryItemLookUpEditscope.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditscope.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ScopeID", "Scope ID", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ScopeName", "ScopeName", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditscope.DisplayMember = "ScopeName";
            repositoryItemLookUpEditscope.Name = "repositoryItemLookUpEditscope";
            repositoryItemLookUpEditscope.ValueMember = "ScopeID";
            // 
            // repositoryItemLookUpEditdescipline
            // 
            repositoryItemLookUpEditdescipline.AutoHeight = false;
            repositoryItemLookUpEditdescipline.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEditdescipline.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesciplineId", "DesciplineId", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesciplineName", "DesciplineName", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEditdescipline.DisplayMember = "DesciplineName";
            repositoryItemLookUpEditdescipline.Name = "repositoryItemLookUpEditdescipline";
            repositoryItemLookUpEditdescipline.ValueMember = "DesciplineId";
            // 
            // repositoryItemTextEditirn
            // 
            repositoryItemTextEditirn.Name = "repositoryItemTextEditirn";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(progressLabel);
            panelControl2.Controls.Add(progressBar1);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Controls.Add(simpleButton1);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Controls.Add(btnRefreshArchiveNO);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 2);
            panelControl2.Margin = new Padding(3, 2, 3, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(955, 33);
            panelControl2.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.Transparent;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.ImageOptions.Image = (Image)resources.GetObject("labelControl2.ImageOptions.Image");
            labelControl2.LineColor = Color.FromArgb(255, 128, 0);
            labelControl2.Location = new Point(19, 9);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(16, 16);
            labelControl2.TabIndex = 145;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.BackColor = Color.Ivory;
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.DimGray;
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.LineColor = Color.FromArgb(255, 128, 0);
            labelControl1.Location = new Point(38, 10);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(74, 14);
            labelControl1.TabIndex = 144;
            labelControl1.Text = "Search Item";
            // 
            // simpleButton1
            // 
            simpleButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(925, 8);
            simpleButton1.Margin = new Padding(3, 2, 3, 2);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(20, 19);
            simpleButton1.TabIndex = 141;
            simpleButton1.ToolTip = "EXPORT EXCEL";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnRefreshArchiveNO
            // 
            btnRefreshArchiveNO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshArchiveNO.ImageOptions.Image = (Image)resources.GetObject("btnRefreshArchiveNO.ImageOptions.Image");
            btnRefreshArchiveNO.Location = new Point(803, 8);
            btnRefreshArchiveNO.Margin = new Padding(3, 2, 3, 2);
            btnRefreshArchiveNO.Name = "btnRefreshArchiveNO";
            btnRefreshArchiveNO.Size = new Size(21, 19);
            btnRefreshArchiveNO.TabIndex = 139;
            btnRefreshArchiveNO.Click += btnRefreshArchiveNO_Click;
            // 
            // ReqMivQty
            // 
            ReqMivQty.Caption = "Req MivQty";
            ReqMivQty.FieldName = "ReqMivQty";
            ReqMivQty.MinWidth = 21;
            ReqMivQty.Name = "ReqMivQty";
            ReqMivQty.Width = 81;
            // 
            // QtyinLoc
            // 
            QtyinLoc.Caption = "Qty in Location";
            QtyinLoc.FieldName = "QtyinLoc";
            QtyinLoc.MinWidth = 21;
            QtyinLoc.Name = "QtyinLoc";
            QtyinLoc.Visible = true;
            QtyinLoc.VisibleIndex = 8;
            QtyinLoc.Width = 98;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Appearance.BorderColor = Color.Silver;
            gridControl1.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Location = new Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEditirn, repositoryItemLookUpEditpo, repositoryItemLookUpEditmr, repositoryItemLookUpEditsupplier, repositoryItemLookUpEditscope, repositoryItemLookUpEditdescipline, repositoryItemTextEditirn });
            gridControl1.Size = new Size(951, 533);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.EvenRow.BackColor = Color.FromArgb(192, 192, 255);
            gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            gridView1.Appearance.GroupRow.BackColor = Color.FromArgb(192, 255, 255);
            gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            gridView1.Appearance.HeaderPanel.BackColor = Color.LightGreen;
            gridView1.Appearance.HeaderPanel.BorderColor = Color.Gray;
            gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { RowNumber, ArrivalDate, MSRNO, PLNO, OPINO, Project, EnteredDate, MARDate, Po, Supplier, Vendor, Mr, IRN, ItemId, PLName, ArchiveNO, PK, Tag, Description, Unit, QtyPL, QtyinLoc, QtyinLocWithMRV, NISQty, RejectQty, ReqMivQty, ReserveMivQty, DelMivQty, ReturnQty, TotalReturnAcceptQty, Balance, Inventory, Descipline, Scope });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            // 
            // RowNumber
            // 
            RowNumber.Caption = "#";
            RowNumber.FieldName = "RowNumber";
            RowNumber.MinWidth = 21;
            RowNumber.Name = "RowNumber";
            RowNumber.Visible = true;
            RowNumber.VisibleIndex = 0;
            RowNumber.Width = 45;
            // 
            // ArrivalDate
            // 
            ArrivalDate.Caption = "Arrival Date";
            ArrivalDate.FieldName = "ArrivalDate";
            ArrivalDate.MinWidth = 21;
            ArrivalDate.Name = "ArrivalDate";
            ArrivalDate.Width = 81;
            // 
            // MSRNO
            // 
            MSRNO.Caption = "MSR NO";
            MSRNO.FieldName = "MSRNO";
            MSRNO.MinWidth = 21;
            MSRNO.Name = "MSRNO";
            MSRNO.Width = 81;
            // 
            // PLNO
            // 
            PLNO.Caption = "PLNO";
            PLNO.FieldName = "PLNO";
            PLNO.MinWidth = 21;
            PLNO.Name = "PLNO";
            PLNO.Width = 81;
            // 
            // OPINO
            // 
            OPINO.Caption = "OPI NO";
            OPINO.FieldName = "OPINO";
            OPINO.MinWidth = 21;
            OPINO.Name = "OPINO";
            OPINO.Width = 81;
            // 
            // Project
            // 
            Project.Caption = "Project";
            Project.FieldName = "Project";
            Project.MinWidth = 21;
            Project.Name = "Project";
            Project.Width = 81;
            // 
            // EnteredDate
            // 
            EnteredDate.Caption = "Entered Date";
            EnteredDate.FieldName = "EnteredDate";
            EnteredDate.MinWidth = 21;
            EnteredDate.Name = "EnteredDate";
            EnteredDate.Visible = true;
            EnteredDate.VisibleIndex = 19;
            EnteredDate.Width = 105;
            // 
            // MARDate
            // 
            MARDate.Caption = "MAR Date";
            MARDate.FieldName = "MARDate";
            MARDate.MinWidth = 21;
            MARDate.Name = "MARDate";
            MARDate.Width = 81;
            // 
            // Po
            // 
            Po.Caption = "Po ";
            Po.FieldName = "Po";
            Po.MinWidth = 21;
            Po.Name = "Po";
            Po.Visible = true;
            Po.VisibleIndex = 1;
            Po.Width = 158;
            // 
            // Supplier
            // 
            Supplier.Caption = "Supplier";
            Supplier.FieldName = "Supplier";
            Supplier.MinWidth = 21;
            Supplier.Name = "Supplier";
            Supplier.Width = 81;
            // 
            // Vendor
            // 
            Vendor.Caption = "Vendor";
            Vendor.FieldName = "Vendor";
            Vendor.MinWidth = 21;
            Vendor.Name = "Vendor";
            Vendor.Width = 81;
            // 
            // Mr
            // 
            Mr.Caption = "Mr";
            Mr.FieldName = "Mr";
            Mr.MinWidth = 21;
            Mr.Name = "Mr";
            Mr.Width = 81;
            // 
            // IRN
            // 
            IRN.Caption = "IRN";
            IRN.FieldName = "IRN";
            IRN.MinWidth = 21;
            IRN.Name = "IRN";
            IRN.Width = 81;
            // 
            // ItemId
            // 
            ItemId.Caption = "Item Id";
            ItemId.FieldName = "ItemId";
            ItemId.MinWidth = 21;
            ItemId.Name = "ItemId";
            ItemId.Width = 69;
            // 
            // PLName
            // 
            PLName.Caption = "PL";
            PLName.FieldName = "PLName";
            PLName.MinWidth = 21;
            PLName.Name = "PLName";
            PLName.Visible = true;
            PLName.VisibleIndex = 2;
            PLName.Width = 158;
            // 
            // ArchiveNO
            // 
            ArchiveNO.Caption = "Archive NO";
            ArchiveNO.FieldName = "ArchiveNO";
            ArchiveNO.MinWidth = 21;
            ArchiveNO.Name = "ArchiveNO";
            ArchiveNO.Width = 81;
            // 
            // PK
            // 
            PK.Caption = "PK";
            PK.FieldName = "PK";
            PK.MinWidth = 21;
            PK.Name = "PK";
            PK.Visible = true;
            PK.VisibleIndex = 3;
            PK.Width = 81;
            // 
            // Tag
            // 
            Tag.Caption = "Tag";
            Tag.FieldName = "Tag";
            Tag.MinWidth = 21;
            Tag.Name = "Tag";
            Tag.Visible = true;
            Tag.VisibleIndex = 4;
            Tag.Width = 81;
            // 
            // Description
            // 
            Description.AppearanceCell.Options.UseTextOptions = true;
            Description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            Description.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            Description.Caption = "Description";
            Description.FieldName = "Description";
            Description.MinWidth = 21;
            Description.Name = "Description";
            Description.Visible = true;
            Description.VisibleIndex = 5;
            Description.Width = 279;
            // 
            // Unit
            // 
            Unit.Caption = "Unit";
            Unit.FieldName = "Unit";
            Unit.MinWidth = 21;
            Unit.Name = "Unit";
            Unit.Visible = true;
            Unit.VisibleIndex = 6;
            Unit.Width = 81;
            // 
            // QtyPL
            // 
            QtyPL.Caption = "Qty PL";
            QtyPL.FieldName = "QtyPL";
            QtyPL.MinWidth = 21;
            QtyPL.Name = "QtyPL";
            QtyPL.Visible = true;
            QtyPL.VisibleIndex = 7;
            QtyPL.Width = 81;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(panelControl3);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Margin = new Padding(3, 2, 3, 2);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(959, 574);
            panelControl1.TabIndex = 1;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(gridControl1);
            panelControl3.Dock = DockStyle.Fill;
            panelControl3.Location = new Point(2, 35);
            panelControl3.Margin = new Padding(3, 2, 3, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(955, 537);
            panelControl3.TabIndex = 2;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            progressLabel.ForeColor = Color.Green;
            progressLabel.Location = new Point(378, 8);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(48, 17);
            progressLabel.TabIndex = 147;
            progressLabel.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(129, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(240, 21);
            progressBar1.TabIndex = 146;
            // 
            // frmSearchItem
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 574);
            Controls.Add(panelControl1);
            IconOptions.LargeImage = (Image)resources.GetObject("frmSearchItem.IconOptions.LargeImage");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSearchItem";
            Text = "Search Item";
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditirn).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditpo).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditmr).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditsupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditscope).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEditdescipline).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEditirn).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn ReserveMivQty;
        private DevExpress.XtraGrid.Columns.GridColumn DelMivQty;
        private DevExpress.XtraGrid.Columns.GridColumn ReturnQty;
        private DevExpress.XtraGrid.Columns.GridColumn TotalReturnAcceptQty;
        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn Inventory;
        private DevExpress.XtraGrid.Columns.GridColumn RejectQty;
        private DevExpress.XtraGrid.Columns.GridColumn NISQty;
        private DevExpress.XtraGrid.Columns.GridColumn Descipline;
        private DevExpress.XtraGrid.Columns.GridColumn Scope;
        private DevExpress.XtraGrid.Columns.GridColumn QtyinLocWithMRV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditirn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditpo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditmr;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditsupplier;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditscope;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditdescipline;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditirn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnRefreshArchiveNO;
        private DevExpress.XtraGrid.Columns.GridColumn ReqMivQty;
        private DevExpress.XtraGrid.Columns.GridColumn QtyinLoc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn RowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ArrivalDate;
        private DevExpress.XtraGrid.Columns.GridColumn MSRNO;
        private DevExpress.XtraGrid.Columns.GridColumn PLNO;
        private DevExpress.XtraGrid.Columns.GridColumn OPINO;
        private DevExpress.XtraGrid.Columns.GridColumn Project;
        private DevExpress.XtraGrid.Columns.GridColumn EnteredDate;
        private DevExpress.XtraGrid.Columns.GridColumn MARDate;
        private DevExpress.XtraGrid.Columns.GridColumn Po;
        private DevExpress.XtraGrid.Columns.GridColumn Supplier;
        private DevExpress.XtraGrid.Columns.GridColumn Vendor;
        private DevExpress.XtraGrid.Columns.GridColumn Mr;
        private DevExpress.XtraGrid.Columns.GridColumn IRN;
        private DevExpress.XtraGrid.Columns.GridColumn ItemId;
        private DevExpress.XtraGrid.Columns.GridColumn PLName;
        private DevExpress.XtraGrid.Columns.GridColumn ArchiveNO;
        private DevExpress.XtraGrid.Columns.GridColumn PK;
        private DevExpress.XtraGrid.Columns.GridColumn Tag;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn QtyPL;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Label progressLabel;
        private ProgressBar progressBar1;
    }
}