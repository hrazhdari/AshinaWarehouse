using AWMS.dapper.Repositories;
using AWMS.dto;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Forms.RibbonSearch
{
    public partial class frmSearchItem : XtraForm
    {
        private readonly IRequestDapperRepository _requestDapperRepository;
        public frmSearchItem(IRequestDapperRepository requestDapperRepository)
        {
            InitializeComponent();
            _requestDapperRepository = requestDapperRepository;
            initGrid();
        }

        private async Task LoadDataIntoGrid()
        {
            int pageNumber = 1;
            int pageSize = 100;
            bool moreData = true;

            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            progressLabel.Visible = true;
            progressLabel.Text = "0%";

            int totalRecords = await _requestDapperRepository.GetTotalItemRecordCount(); // دریافت تعداد کل رکوردها
            MessageBox.Show("item = "+totalRecords);
            List<MaterialIssueVoucherDto> allData = new List<MaterialIssueVoucherDto>();

            try
            {
                while (moreData)
                {
                    var data = await _requestDapperRepository.SearchItemFillGrid(pageNumber, pageSize);

                    if (data.Any())
                    {
                        allData.AddRange(data);
                        gridControl1.DataSource = allData;

                        pageNumber++;
                        int percentage = (int)((double)allData.Count / totalRecords * 100);

                        progressBar1.Value = percentage;
                        progressLabel.Text = $"{percentage}%";
                    }
                    else
                    {
                        moreData = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                progressLabel.Text = "Error loading data: " + ex.Message;
            }
            finally
            {
                progressBar1.Visible = false;
                progressLabel.Visible = false;
            }
        }
        private async void initGrid()
        {
            // پنهان کردن ProgressBar پیش از بارگیری داده‌ها
            progressBar1.Visible = false;

            // بارگیری داده‌ها به صورت تکه‌تکه
            await LoadDataIntoGrid();
        }
        private void labelControl4_Click_1(object sender, EventArgs e)
        {
            btnRefreshArchiveNO_Click(null, null);
        }

        private void btnRefreshArchiveNO_Click(object sender, EventArgs e)
        {
            initGrid();
            XtraMessageBox.Show("All Data Refreshed ;)");
        }
        private void SaveGridData(string filter, string title, Action<string> exportAction)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportAction.Invoke(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show($"{Path.GetExtension(saveFileDialog.FileName)} file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveGridData("PDF Files|*.pdf", "Save PDF File", fileName => gridView1.ExportToPdf(fileName));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.Print();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveGridData("Excel Files|*.xlsx", "Save Excel File", fileName => gridView1.ExportToXlsx(fileName));
        }
    }
}
