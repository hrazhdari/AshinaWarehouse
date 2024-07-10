using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace AWMS.app.Utility
{
    public static class ExportFromGridViewDevexpress
    {
        public static void ExportToExcel(GridView gridView, string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    string sheetName = "Data";
                    int sheetIndex = 1;

                    // پیدا کردن نام یکتا برای شیت جدید
                    while (package.Workbook.Worksheets[sheetName] != null)
                    {
                        sheetName = "Data" + sheetIndex;
                        sheetIndex++;
                    }

                    // ایجاد شیت جدید با نام یکتا
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(sheetName);

                    // افزودن سرستون‌ها
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = gridView.Columns[i].Caption;
                        worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                    }

                    // افزودن ردیف‌های داده
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        for (int j = 0; j < gridView.Columns.Count; j++)
                        {
                            var cellValue = gridView.GetRowCellValue(i, gridView.Columns[j]);
                            worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                            worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                        }
                    }

                    // ذخیره فایل
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
