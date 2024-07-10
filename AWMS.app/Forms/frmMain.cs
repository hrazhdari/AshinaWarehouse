﻿//using AWSapp.frmBase;
//using AWSapp.frmSmall;
//using AWSapp.RibbonDashboard;
//using AWSapp.RibbonMaterial;
//using AWSapp.RibbonReport;
//using AWSapp.RibbonSearch;
//using AWSapp.RibbonVoucher;
//using AWSapp.Utility;
using AWMS.app.Utility;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace AWMS.app.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        public frmMain(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Icon = Properties.Resources.warehouse2024;
            barStaticItem2.Caption = " :: " + DateMiladiShamsi.DateMiladi() + " : " + DateMiladiShamsi.DateShamsi();
        }

        private void CompanybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var CompanyManagmentForm = _serviceProvider.GetRequiredService<Forms.frmCompanyManagment>();
            CompanyManagmentForm.MdiParent = this;
            CompanyManagmentForm.Show();
        }

        private void MrbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var MrManagmentForm = _serviceProvider.GetRequiredService<Forms.RibbonMaterial.frmMr>();
            MrManagmentForm.MdiParent = this;
            MrManagmentForm.Show();
        }
    }
}