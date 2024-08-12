namespace AWMS.app.Forms
{
    partial class frmCompanyContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyContract));
            bar1 = new DevExpress.XtraBars.Bar();
            btnexcel = new DevExpress.XtraBars.BarButtonItem();
            btndelete = new DevExpress.XtraBars.BarButtonItem();
            standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            gridcontrol = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPKID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPLId = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colContractNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colDesciption = new DevExpress.XtraGrid.Columns.GridColumn();
            colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            colEditedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colEditedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colEnteredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            lookUpEditCompany = new DevExpress.XtraEditors.LookUpEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            enteredDateContract = new DevExpress.XtraEditors.DateEdit();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            txtContractDescription = new DevExpress.XtraEditors.MemoEdit();
            btnAddContract = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            lblMrDescirption = new DevExpress.XtraEditors.LabelControl();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            lblcount = new DevExpress.XtraEditors.LabelControl();
            txtContractRemark = new DevExpress.XtraEditors.MemoEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtContractNumber = new DevExpress.XtraEditors.TextEdit();
            labelControl26 = new DevExpress.XtraEditors.LabelControl();
            splitContainer1 = new SplitContainer();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditCompany.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enteredDateContract.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enteredDateContract.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContractDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtContractRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtContractNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // bar1
            // 
            bar1.BarName = "Custom 2";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            bar1.FloatLocation = new Point(366, 190);
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnexcel), new DevExpress.XtraBars.LinkPersistInfo(btndelete) });
            bar1.OptionsBar.AllowQuickCustomization = false;
            bar1.OptionsBar.DistanceBetweenItems = 5;
            bar1.OptionsBar.UseWholeRow = true;
            bar1.StandaloneBarDockControl = standaloneBarDockControl1;
            bar1.Text = "Custom 2";
            // 
            // btnexcel
            // 
            btnexcel.Caption = "Export Excel";
            btnexcel.Id = 0;
            btnexcel.ImageOptions.Image = Properties.Resources.exporttoxls_16x163;
            btnexcel.ImageOptions.LargeImage = Properties.Resources.exporttoxls_16x163;
            btnexcel.Name = "btnexcel";
            btnexcel.ItemClick += btnexcel_ItemClick;
            // 
            // btndelete
            // 
            btndelete.Caption = "Delete Item";
            btndelete.Enabled = false;
            btndelete.Id = 1;
            btndelete.ImageOptions.Image = Properties.Resources.none_16x162;
            btndelete.ImageOptions.LargeImage = Properties.Resources.none_16x162;
            btndelete.Name = "btndelete";
            btndelete.ItemClick += btndelete_ItemClick;
            // 
            // standaloneBarDockControl1
            // 
            standaloneBarDockControl1.CausesValidation = false;
            standaloneBarDockControl1.Dock = DockStyle.Fill;
            standaloneBarDockControl1.Location = new Point(0, 0);
            standaloneBarDockControl1.Manager = barManager1;
            standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            standaloneBarDockControl1.Size = new Size(814, 27);
            standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager1.DockControls.Add(barDockControl1);
            barManager1.DockControls.Add(barDockControl2);
            barManager1.DockControls.Add(barDockControl3);
            barManager1.DockControls.Add(barDockControl4);
            barManager1.DockControls.Add(standaloneBarDockControl1);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnexcel, btndelete });
            barManager1.MaxItemId = 2;
            // 
            // barDockControl1
            // 
            barDockControl1.CausesValidation = false;
            barDockControl1.Dock = DockStyle.Top;
            barDockControl1.Location = new Point(0, 0);
            barDockControl1.Manager = barManager1;
            barDockControl1.Size = new Size(1116, 0);
            // 
            // barDockControl2
            // 
            barDockControl2.CausesValidation = false;
            barDockControl2.Dock = DockStyle.Bottom;
            barDockControl2.Location = new Point(0, 612);
            barDockControl2.Manager = barManager1;
            barDockControl2.Size = new Size(1116, 0);
            // 
            // barDockControl3
            // 
            barDockControl3.CausesValidation = false;
            barDockControl3.Dock = DockStyle.Left;
            barDockControl3.Location = new Point(0, 0);
            barDockControl3.Manager = barManager1;
            barDockControl3.Size = new Size(0, 612);
            // 
            // barDockControl4
            // 
            barDockControl4.CausesValidation = false;
            barDockControl4.Dock = DockStyle.Right;
            barDockControl4.Location = new Point(1116, 0);
            barDockControl4.Manager = barManager1;
            barDockControl4.Size = new Size(0, 612);
            // 
            // gridcontrol
            // 
            gridcontrol.Dock = DockStyle.Fill;
            gridcontrol.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridcontrol.Location = new Point(0, 0);
            gridcontrol.MainView = gridView1;
            gridcontrol.Margin = new Padding(3, 2, 3, 2);
            gridcontrol.Name = "gridcontrol";
            gridcontrol.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEdit1 });
            gridcontrol.Size = new Size(814, 581);
            gridcontrol.TabIndex = 1;
            gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colPKID, colPLId, colContractNumber, colDesciption, colRemark, colEditedBy, colEnteredBy, colEditedDate, colEnteredDate });
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridcontrol;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 600;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFooter = true;
            // 
            // colPKID
            // 
            colPKID.Caption = "ContractID";
            colPKID.FieldName = "ContractId";
            colPKID.MinWidth = 21;
            colPKID.Name = "colPKID";
            colPKID.OptionsColumn.AllowEdit = false;
            colPKID.Width = 81;
            // 
            // colPLId
            // 
            colPLId.Caption = "Company";
            colPLId.ColumnEdit = repositoryItemLookUpEdit1;
            colPLId.FieldName = "CompanyID";
            colPLId.MinWidth = 21;
            colPLId.Name = "colPLId";
            colPLId.OptionsColumn.AllowEdit = false;
            colPLId.OptionsColumn.ReadOnly = true;
            colPLId.Visible = true;
            colPLId.VisibleIndex = 2;
            colPLId.Width = 81;
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrId", "Mr Id", 15, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MrName", "Mr Name", 15, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            repositoryItemLookUpEdit1.DisplayMember = "CompanyName";
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            repositoryItemLookUpEdit1.ValueMember = "CompanyID";
            // 
            // colContractNumber
            // 
            colContractNumber.Caption = "Contract Number";
            colContractNumber.FieldName = "ContractNumber";
            colContractNumber.MinWidth = 21;
            colContractNumber.Name = "colContractNumber";
            colContractNumber.Visible = true;
            colContractNumber.VisibleIndex = 1;
            colContractNumber.Width = 81;
            // 
            // colDesciption
            // 
            colDesciption.Caption = "Description";
            colDesciption.FieldName = "ContractDescription";
            colDesciption.MinWidth = 21;
            colDesciption.Name = "colDesciption";
            colDesciption.Visible = true;
            colDesciption.VisibleIndex = 0;
            colDesciption.Width = 81;
            // 
            // colRemark
            // 
            colRemark.Caption = "Remark";
            colRemark.FieldName = "ContractRemark";
            colRemark.MinWidth = 21;
            colRemark.Name = "colRemark";
            colRemark.Visible = true;
            colRemark.VisibleIndex = 3;
            colRemark.Width = 81;
            // 
            // colEditedBy
            // 
            colEditedBy.Caption = "Edited By";
            colEditedBy.FieldName = "EditedBy";
            colEditedBy.Name = "colEditedBy";
            // 
            // colEnteredBy
            // 
            colEnteredBy.Caption = "Entered By";
            colEnteredBy.FieldName = "EnteredBy";
            colEnteredBy.MinWidth = 21;
            colEnteredBy.Name = "colEnteredBy";
            colEnteredBy.OptionsColumn.AllowEdit = false;
            colEnteredBy.Width = 81;
            // 
            // colEditedDate
            // 
            colEditedDate.Caption = "Edited Date";
            colEditedDate.FieldName = "EditedDate";
            colEditedDate.Name = "colEditedDate";
            // 
            // colEnteredDate
            // 
            colEnteredDate.Caption = "Entered Date";
            colEnteredDate.FieldName = "EnteredDate";
            colEnteredDate.MinWidth = 21;
            colEnteredDate.Name = "colEnteredDate";
            colEnteredDate.OptionsColumn.AllowEdit = false;
            colEnteredDate.Width = 81;
            // 
            // lookUpEditCompany
            // 
            lookUpEditCompany.Location = new Point(15, 78);
            lookUpEditCompany.Margin = new Padding(3, 2, 3, 2);
            lookUpEditCompany.Name = "lookUpEditCompany";
            lookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyID", "CompanyID", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Companies", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            lookUpEditCompany.Properties.DisplayMember = "CompanyName";
            lookUpEditCompany.Properties.NullText = "Select Company ...";
            lookUpEditCompany.Properties.ValueMember = "CompanyID";
            lookUpEditCompany.Size = new Size(261, 20);
            lookUpEditCompany.TabIndex = 0;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.ForeColor = Color.Silver;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(9, 30);
            labelControl3.Margin = new Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(115, 12);
            labelControl3.TabIndex = 14;
            labelControl3.Text = "Contract Of Companies";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.SteelBlue;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(9, 8);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(131, 17);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "Company Contract";
            // 
            // enteredDateContract
            // 
            enteredDateContract.EditValue = null;
            enteredDateContract.Location = new Point(102, 434);
            enteredDateContract.Margin = new Padding(3, 2, 3, 2);
            enteredDateContract.Name = "enteredDateContract";
            enteredDateContract.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            enteredDateContract.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            enteredDateContract.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            enteredDateContract.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            enteredDateContract.Size = new Size(174, 20);
            enteredDateContract.TabIndex = 5;
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(16, 537);
            progressBarControl1.Margin = new Padding(3, 2, 3, 2);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Size = new Size(260, 18);
            progressBarControl1.TabIndex = 0;
            // 
            // txtContractDescription
            // 
            txtContractDescription.Location = new Point(15, 221);
            txtContractDescription.Margin = new Padding(3, 2, 3, 2);
            txtContractDescription.Name = "txtContractDescription";
            txtContractDescription.Size = new Size(261, 80);
            txtContractDescription.TabIndex = 6;
            // 
            // btnAddContract
            // 
            btnAddContract.ImageOptions.Image = Properties.Resources.functionsmore_32x32;
            btnAddContract.Location = new Point(16, 485);
            btnAddContract.Margin = new Padding(3, 2, 3, 2);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(260, 46);
            btnAddContract.TabIndex = 8;
            btnAddContract.Text = "&Add Contract";
            btnAddContract.ToolTip = "Alt+A To Add Mr";
            btnAddContract.Click += btnAddContract_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(16, 438);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(71, 13);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Entered Date :";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "ribbonPage2";
            // 
            // lblMrDescirption
            // 
            lblMrDescirption.Location = new Point(15, 202);
            lblMrDescirption.Margin = new Padding(3, 2, 3, 2);
            lblMrDescirption.Name = "lblMrDescirption";
            lblMrDescirption.Size = new Size(105, 13);
            lblMrDescirption.TabIndex = 8;
            lblMrDescirption.Text = "Contract Description :";
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
            splitContainerControl1.Panel1.Controls.Add(labelControl4);
            splitContainerControl1.Panel1.Controls.Add(labelControl6);
            splitContainerControl1.Panel1.Controls.Add(lblcount);
            splitContainerControl1.Panel1.Controls.Add(txtContractRemark);
            splitContainerControl1.Panel1.Controls.Add(labelControl5);
            splitContainerControl1.Panel1.Controls.Add(txtContractNumber);
            splitContainerControl1.Panel1.Controls.Add(labelControl26);
            splitContainerControl1.Panel1.Controls.Add(lookUpEditCompany);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(enteredDateContract);
            splitContainerControl1.Panel1.Controls.Add(progressBarControl1);
            splitContainerControl1.Panel1.Controls.Add(txtContractDescription);
            splitContainerControl1.Panel1.Controls.Add(btnAddContract);
            splitContainerControl1.Panel1.Controls.Add(lblMrDescirption);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(splitContainer1);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1116, 612);
            splitContainerControl1.SplitterPosition = 292;
            splitContainerControl1.TabIndex = 79;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.ForeColor = Color.Silver;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(20, 461);
            labelControl4.Margin = new Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(0, 12);
            labelControl4.TabIndex = 86;
            // 
            // labelControl6
            // 
            labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            labelControl6.ImageOptions.Image = Properties.Resources.icons8_company_16;
            labelControl6.Location = new Point(18, 53);
            labelControl6.Margin = new Padding(3, 2, 3, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(66, 20);
            labelControl6.TabIndex = 85;
            labelControl6.Text = "Company";
            // 
            // lblcount
            // 
            lblcount.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcount.Appearance.ForeColor = Color.DarkOrchid;
            lblcount.Appearance.Options.UseFont = true;
            lblcount.Appearance.Options.UseForeColor = true;
            lblcount.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            lblcount.ImageOptions.Image = (Image)resources.GetObject("lblcount.ImageOptions.Image");
            lblcount.Location = new Point(16, 107);
            lblcount.Margin = new Padding(3, 2, 3, 2);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(30, 20);
            lblcount.TabIndex = 79;
            lblcount.Text = "...";
            // 
            // txtContractRemark
            // 
            txtContractRemark.Location = new Point(15, 336);
            txtContractRemark.Margin = new Padding(3, 2, 3, 2);
            txtContractRemark.Name = "txtContractRemark";
            txtContractRemark.Size = new Size(261, 80);
            txtContractRemark.TabIndex = 7;
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(15, 314);
            labelControl5.Margin = new Padding(3, 2, 3, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(88, 13);
            labelControl5.TabIndex = 72;
            labelControl5.Text = "Contract Remark :";
            // 
            // txtContractNumber
            // 
            txtContractNumber.Location = new Point(15, 164);
            txtContractNumber.Margin = new Padding(3, 2, 3, 2);
            txtContractNumber.Name = "txtContractNumber";
            txtContractNumber.Size = new Size(261, 20);
            txtContractNumber.TabIndex = 4;
            // 
            // labelControl26
            // 
            labelControl26.Appearance.ForeColor = Color.Navy;
            labelControl26.Appearance.Options.UseForeColor = true;
            labelControl26.Location = new Point(15, 144);
            labelControl26.Margin = new Padding(3, 2, 3, 2);
            labelControl26.Name = "labelControl26";
            labelControl26.Size = new Size(89, 13);
            labelControl26.TabIndex = 70;
            labelControl26.Text = "Contract Number :";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(standaloneBarDockControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gridcontrol);
            splitContainer1.Size = new Size(814, 612);
            splitContainer1.SplitterDistance = 27;
            splitContainer1.TabIndex = 1;
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = null;
            barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new Size(0, 0);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Location = new Point(0, 0);
            barDockControlRight.Manager = null;
            barDockControlRight.Margin = new Padding(3, 2, 3, 2);
            barDockControlRight.Size = new Size(0, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Location = new Point(0, 0);
            barDockControlBottom.Manager = null;
            barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new Size(0, 0);
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = null;
            barDockControlTop.Margin = new Padding(3, 2, 3, 2);
            barDockControlTop.Size = new Size(0, 0);
            // 
            // frmCompanyContract
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 612);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(barDockControl3);
            Controls.Add(barDockControl4);
            Controls.Add(barDockControl2);
            Controls.Add(barDockControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Icon = (Icon)resources.GetObject("frmCompanyContract.IconOptions.Icon");
            IconOptions.Image = Properties.Resources.functionsmore_16x16;
            MaximizeBox = false;
            Name = "frmCompanyContract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Contract";
            Load += frmCompanyContract_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditCompany.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)enteredDateContract.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)enteredDateContract.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContractDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtContractRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtContractNumber.Properties).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnexcel;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblcount;
        private DevExpress.XtraEditors.MemoEdit txtContractRemark;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContractNumber;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompany;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit enteredDateContract;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.MemoEdit txtContractDescription;
        private DevExpress.XtraEditors.SimpleButton btnAddContract;
        private DevExpress.XtraEditors.LabelControl lblMrDescirption;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPKID;
        private DevExpress.XtraGrid.Columns.GridColumn colPLId;
        private DevExpress.XtraGrid.Columns.GridColumn colPK;
        private DevExpress.XtraGrid.Columns.GridColumn colNetW;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossW;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colArrivalDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDesciption;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredBy;
        private DevExpress.XtraGrid.Columns.GridColumn colEnteredDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colEditedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colEditedDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}