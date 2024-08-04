using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using DevExpress.Utils.CommonDialogs;
using System.IO;
using System.Collections;
using DevExpress.XtraEditors;
using AWMS.app.Forms.RibbonUser;
using AWMS.app.Utility;
using DevExpress.XtraBars;
using AWMS.dapper.Repositories;
using AWMS.dapper;
using AWMS.dto;
using Microsoft.Extensions.Configuration; // افزودن این using

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmImportPackingList : XtraForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILocationDapperRepository _locationDapperRepository;
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private readonly IPackageDapperRepository _packageDapperRepository;
        private readonly IConfiguration _configuration; // افزودن این فیلد
        private readonly int _userId;
        private readonly UserSession _session; // اضافه کردن متغیر سراسری برای UserSession

        public frmImportPackingList(IServiceProvider serviceProvider, int userId,
            ILocationDapperRepository locationDapperRepository,
            IPackingListDapperRepository packingListDapperRepository,
            IPackageDapperRepository packageDapperRepository,
            IConfiguration configuration) // افزودن IConfiguration به سازنده
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userId = userId;
            _locationDapperRepository = locationDapperRepository;
            _packingListDapperRepository = packingListDapperRepository;
            _packageDapperRepository = packageDapperRepository;
            _configuration = configuration; // مقداردهی فیلد

            // گرفتن نشست کاربر و ذخیره آن در متغیر سراسری
            _session = SessionManager.GetSession(_userId);
            initgrid();
        }

        public async void initgrid()
        {
            chkEdit_CheckedChanged(null, null);
            lookUpEditLocation.Properties.DataSource = await _locationDapperRepository.GetAllAsync();
        }

        private async void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked)
            {
                lookUpEditPL.Properties.DataSource = await _packingListDapperRepository.GetAllPlNameAsync();
            }
            else
            {
                LoadPackingListsWithoutPackages();
            }
        }

        private async void LoadPackingListsWithoutPackages()
        {
            lookUpEditPL.Properties.DataSource = await _packingListDapperRepository.GetPackingListsWithoutPackagesAsync();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string selectedLookupValue = "";
            int locationLookupValue;

            if (lookUpEditPL.EditValue != null)
            {
                selectedLookupValue = lookUpEditPL.Text;
            }
            else
            {
                MessageBox.Show("Please Select Packing List ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lookUpEditLocation.EditValue != null)
            {
                locationLookupValue = Convert.ToInt32(lookUpEditLocation.EditValue);
            }
            else
            {
                MessageBox.Show("Please Select Location ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (selectedFileName.Equals(selectedLookupValue, StringComparison.OrdinalIgnoreCase))
                {
                    using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(openFileDialog.FileName)))
                    {
                        var worksheet = package.Workbook.Worksheets["Pk"];
                        if (worksheet == null)
                        {
                            MessageBox.Show("Sheet named 'Pk' not found in the selected Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var packages = ReadPackagesFromExcel(worksheet, (int)lookUpEditPL.EditValue);

                        // بررسی کنید که بسته‌ها قبل از ارسال به مخزن پر شده باشند
                        if (packages.Any())
                        {
                            _packageDapperRepository.AddPackages(packages);
                            // بارگذاری و نمایش داده‌ها در گرید
                            LoadPackagesForPL((int)lookUpEditPL.EditValue);
                            MessageBox.Show("Packages imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No valid data found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Packing List and Excel File name do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private IEnumerable<PackageDto> ReadPackagesFromExcel(ExcelWorksheet worksheet, int plId)
        {
            if (worksheet == null)
            {
                throw new ArgumentNullException(nameof(worksheet), "Worksheet cannot be null.");
            }

            var packages = new List<PackageDto>();

            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                var cellValue1 = worksheet.Cells[row, 1].Value; // PK
                var cellValue2 = worksheet.Cells[row, 2].Value; // NetW
                var cellValue3 = worksheet.Cells[row, 3].Value; // GrossW
                var cellValue4 = worksheet.Cells[row, 4].Value; // Dimension
                var cellValue5 = worksheet.Cells[row, 5].Value; // Volume
                var cellValue6 = worksheet.Cells[row, 6].Value; // ArrivalDate
                var cellValue7 = worksheet.Cells[row, 7].Value; // Desciption
                var cellValue8 = worksheet.Cells[row, 8].Value; // Remark

                // بررسی اینکه مقدار PK خالی نباشد
                if (cellValue1 == null || string.IsNullOrWhiteSpace(cellValue1.ToString()))
                {
                    continue; // اگر PK خالی بود، ردیف را نادیده بگذارید
                }

                // مقدار پیش‌فرض برای ArrivalDate
                DateTime arrivalDate;
                if (cellValue6 == null || !DateTime.TryParse(cellValue6.ToString(), out arrivalDate))
                {
                    arrivalDate = DateTime.Now;
                }

                // تبدیل مقادیر به نوع مناسب و اضافه کردن به لیست
                var packageDto = new PackageDto
                {
                    PK = Convert.ToInt32(cellValue1),
                    NetW = cellValue2 != null ? Convert.ToDecimal(cellValue2) : 0.00m,
                    GrossW = cellValue3 != null ? Convert.ToDecimal(cellValue3) : 0.00m,
                    Dimension = cellValue4 != null ? cellValue4.ToString() : string.Empty,
                    Volume = cellValue5 != null ? cellValue5.ToString() : string.Empty,
                    ArrivalDate = arrivalDate,
                    Desciption = cellValue7 != null ? cellValue7.ToString() : string.Empty,
                    Remark = cellValue8 != null ? cellValue8.ToString() : string.Empty,
                    EnteredBy = _session.UserID,
                    EnteredDate = DateTime.Now,
                    PLId = plId // مقدار PLId از پارامتر ورودی متد
                };

                packages.Add(packageDto);
            }

            return packages;
        }

        private void btnAddIrn_Click(object sender, EventArgs e)
        {
            //frmLocation frmchild = new frmLocation();
            //frmchild.ShowDialog();
        }

        private void btnRefreshArchiveNO_Click(object sender, EventArgs e)
        {
            initgrid();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            btnRefreshArchiveNO_Click(null, null);
        }
        private void LoadPackagesForPL(int plId)
        {
            var packages =  _packageDapperRepository.GetPackageByPLId(plId);
            gridControl1.DataSource = packages;
        }

    }
}
