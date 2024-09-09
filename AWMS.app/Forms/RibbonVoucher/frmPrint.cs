using AWMS.report;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Forms.RibbonVoucher
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //var assembly = Assembly.GetAssembly(typeof(AWMS.report.Mivp)); // Replace with actual class name

            //using (Stream stream = assembly.GetManifestResourceStream("AWMS.report.Report1.repx"))
            //{
            //    if (stream != null)
            //    {
            //        XtraReport report = new XtraReport();
            //        report.LoadLayout(stream);
            //        documentViewer1.DocumentSource = report;
            //        documentViewer1.BringToFront();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Report file not found in the specified assembly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            MivReportFront report = new MivReportFront();
            documentViewer1.DocumentSource = report;
            report.CreateDocument();



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // مسیر فایل PDF که می‌خواهید لود کنید
                    string pdfFilePath = "D:\\MyBigProject\\AshinaWarehouse\\AWMS.report\\h.pdf";

                    // بارگذاری فایل PDF در PdfViewer
                    pdfViewer1.LoadDocument(pdfFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
