using AWMS.app.Forms.frmBase;
using AWMS.app.Properties;
using AWMS.app.Utility;
using AWMS.core.Interfaces;
using AWMS.datalayer.Entities;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AWMS.app.Forms
{
    public partial class frmCompanyManagment : frmBase.frmBase
    {
        private readonly ICompanyService _CompanyService;
        private bool isAddingNewCompany = false;

        public frmCompanyManagment(ICompanyService companyService)
        {
            InitializeComponent();
            this._CompanyService = companyService;
            InitializeGridView();
        }
        #region Functions

        // Grid Control Code
        private void InitializeGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellMouseEnter += DataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += DataGridView1_CellMouseLeave;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellToolTipTextNeeded += DataGridView1_CellToolTipTextNeeded;
            CustomizeDataGridView(); // فراخوانی تابع برای اعمال تنظیمات خشگلاسی

            // تعریف سایر ستون‌ها
            DataGridViewTextBoxColumn companyidColumn = new DataGridViewTextBoxColumn();
            companyidColumn.Name = "Companyid";
            companyidColumn.HeaderText = "ID";
            companyidColumn.Width = 10;
            companyidColumn.DataPropertyName = "CompanyID";
            dataGridView1.Columns.Add(companyidColumn);

            DataGridViewTextBoxColumn companyNameColumn = new DataGridViewTextBoxColumn();
            companyNameColumn.Name = "CompanyName";
            companyNameColumn.HeaderText = "Company Name";
            companyNameColumn.DataPropertyName = "CompanyName";
            dataGridView1.Columns.Add(companyNameColumn);

            DataGridViewTextBoxColumn abbreviationColumn = new DataGridViewTextBoxColumn();
            abbreviationColumn.Name = "Abbreviation";
            abbreviationColumn.HeaderText = "Abbreviation";
            abbreviationColumn.DataPropertyName = "Abbreviation";
            dataGridView1.Columns.Add(abbreviationColumn);

            // تبدیل ستون CompanyLogo به لینک
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.Name = "CompanyLogo";
            linkColumn.HeaderText = "Company Logo";
            linkColumn.DataPropertyName = "CompanyLogo";
            dataGridView1.Columns.Add(linkColumn);

            DataGridViewTextBoxColumn remarkColumn = new DataGridViewTextBoxColumn();
            remarkColumn.Name = "Remark";
            remarkColumn.HeaderText = "Remark";
            remarkColumn.DataPropertyName = "Remark";
            dataGridView1.Columns.Add(remarkColumn);

            //// تنظیم جایگاه ستون CompanyLogo
            //DataGridViewColumn companyLogoColumn = dataGridView1.Columns["CompanyLogo"];
            //companyLogoColumn.DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["Companyid"].Width = 36; // عرض ستون را به 36 پیکسل تنظیم می‌کند
            dataGridView1.Columns["Companyid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CompanyName"].Width = 150; // عرض ستون را به 150 پیکسل تنظیم می‌کند
            dataGridView1.Columns["Abbreviation"].Width = 120; // عرض ستون را به 120 پیکسل تنظیم می‌کند
            dataGridView1.Columns["Abbreviation"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // چک کنید که آیا ستون کلیک شده CompanyLogo است یا خیر
            if (e.ColumnIndex == dataGridView1.Columns["CompanyLogo"].Index && e.RowIndex >= 0)
            {
                string filePath = Path.Combine(Application.StartupPath, "CompanyLogoImg", dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                // بررسی وجود فایل
                if (File.Exists(filePath))
                {
                    // نمایش تصویر در یک فرم جدید
                    Form imageForm = new Form();
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(filePath),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill
                    };
                    imageForm.Controls.Add(pictureBox);
                    imageForm.Text = "Company Logo";
                    imageForm.Size = new Size(800, 600);
                    imageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // روی سر ستون حرکت کردید
            {
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightBlue;
                dataGridView1.Cursor = Cursors.Hand; // تغییر آیکون موس به دسته
            }
        }

        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // از روی سر ستون خارج شدید
            {
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.Cursor = Cursors.Default; // تغییر آیکون موس به معمولی
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAddingNewCompany)
            {
                UpdateButtonsAndEditOrAddState();
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (!isAddingNewCompany)
            {
                UpdateButtonsAndEditOrAddState();
            }
        }

        private void DataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dataGridView1 != null && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.ToolTipText = dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString();
            }
        }
        private void CustomizeDataGridView()
        {
            // Row headers
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.Blue;

            // Column headers
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);

            // Cell styling
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternating row colors
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Grid lines
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Auto size columns mode
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // End Of Grid Control Code

        private async Task gridDataLoad()
        {
            try
            {
                // تغییر نشانگر موس به حالت لودینگ
                Cursor.Current = Cursors.WaitCursor;

                // بارگذاری داده‌ها
                var Companies = await _CompanyService.GetAllCompaniesAsync();

                // تنظیم داده‌ها به DataGridView
                dataGridView1.DataSource = Companies;
            }
            catch (Exception ex)
            {
                // مدیریت خطاها
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // بازگرداندن نشانگر موس به حالت پیش‌فرض
                Cursor.Current = Cursors.Default;
            }
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
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
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                    }

                    // افزودن ردیف‌های داده
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
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
        private bool ValidateForm()
        {

            //--------------Validation TextBoxes----------------//
            var textboxes = groupBox3.Controls.Cast<Control>()
                .OfType<TextBox>()
                .OrderBy(control => control.TabIndex);
            foreach (var textbox in textboxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Focus();
                    errorProvider1.Clear();
                    errorProvider1.SetError(textbox, "ورودی الزامی است");
                    return false;
                }
            }

            errorProvider1.Clear();
            return true;
        }

        private void ScrollToNewCompany(int companyId)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["CompanyId"].Value) == companyId)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void UpdateButtonsAndEditOrAddState()
        {
            // Check if any rows are selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btndelete.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int companyId = Convert.ToInt32(selectedRow.Cells["CompanyId"].Value);
                LoadGridDataToTheForm(companyId);
            }
            else
            {
                btndelete.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
        private async void LoadGridDataToTheForm(int companyId)
        {
            lblid.Text = companyId.ToString();
            // Load company data into the form fields
            var company = await _CompanyService.GetCompanyByIdAsync(companyId);

            if (company != null)
            {
                txtCompanyName.Text = company.CompanyName;
                txtAbbreviation.Text = company.Abbreviation;
                richTextBox1.Text = company.Remark;

                if (!string.IsNullOrEmpty(company.CompanyLogo))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "CompanyLogoImg", company.CompanyLogo);
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg; ;
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg; ;
                }

            }
        }
        #endregion

        private async void frmCompanyManagment_Load(object sender, EventArgs e)
        {
            await gridDataLoad();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                isAddingNewCompany = true;

                string? companyLogo = null;

                // Check if the company name is unique
                var uniqueNameCheck = await _CompanyService.GetByCompanyNameAsync(txtCompanyName.Text);
                if (uniqueNameCheck != null)
                {
                    // Scroll to the existing company in the grid
                    ScrollToNewCompany(uniqueNameCheck.Value);
                    CustomMessageBox customMessageBox2 = new CustomMessageBox("Company Name Must Be Unique!", "Error", false);
                    customMessageBox2.ShowDialog(this);
                    return; // Exit the method if the company name is not unique
                }

                // Check if the user has selected an image
                if (pictureBox1.Image != null && !string.IsNullOrEmpty(_fileNameImage))
                {
                    //----------Set Image For Bank Logo --------------//
                    string directoryPath = Path.Combine(Application.StartupPath, "CompanyLogoImg");
                    string fileName = _fileNameImage;

                    // Check if a file with the same name already exists
                    string savePath = Path.Combine(directoryPath, fileName);
                    if (File.Exists(savePath))
                    {
                        // Generate a new unique file name
                        string uniqueFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{Guid.NewGuid()}{Path.GetExtension(fileName)}";
                        savePath = Path.Combine(directoryPath, uniqueFileName);
                        companyLogo = uniqueFileName; // Update companyLogo with the new file name
                    }
                    else
                    {
                        companyLogo = fileName; // Use the original file name
                    }

                    // Create the directory if it doesn't exist
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Save the image with error handling
                    try
                    {
                        pictureBox1.Image.Save(savePath);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception (e.g., log it, show a message to the user, etc.)
                        MessageBox.Show($"An error occurred while saving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the image couldn't be saved
                    }
                }

                var newCompany = new Company()
                {
                    CompanyName = txtCompanyName.Text.Trim(),
                    Abbreviation = txtAbbreviation.Text.Trim(),
                    Remark = richTextBox1.Text.Trim(),
                    CompanyLogo = companyLogo
                };

                var newCompanyId = await _CompanyService.AddCompanyAsync(newCompany);
                await gridDataLoad();

                CustomMessageBox customMessageBox = new CustomMessageBox("Company added successfully!", "Success", true);
                customMessageBox.ShowDialog(this);

                // Clear input fields
                txtCompanyName.Text = "";
                txtAbbreviation.Text = "";
                richTextBox1.Text = "";
                pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg;
                _path = "";
                _fileNameImage = "";
                txtCompanyName.Focus();

                // Scroll to the new company in the grid
                ScrollToNewCompany(newCompanyId);
                isAddingNewCompany = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Display confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells["colRowCount"].Value = e.RowIndex + 1;
        }
        private string _path = "";
        private string _fileNameImage = "";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Title = "Select Logo For Company";
                // dialog.Filter = "PNG Files|*.png|JPG Files|*.jpg|All Files|*.*";
                dialog.Filter = "PNG Files|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _path = dialog.FileName;
                    if (dialog.SafeFileName != null)
                    {
                        _fileNameImage = dialog.SafeFileName.Replace(' ', '_');
                    }

                    // Release any previously loaded image
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    try
                    {
                        // Load the new image
                        using (FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(fs);
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("The file you selected is not a valid image format or is too large.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assume the company ID is stored in the first cell
                int companyId = Convert.ToInt32(selectedRow.Cells["CompanyId"].Value);

                // Get the company object from the grid
                Company companyToDelete = await _CompanyService.GetCompanyByIdAsync(companyId);
                if (companyToDelete == null)
                {
                    MessageBox.Show("Selected company not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete the selected company?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the company from the database
                        await _CompanyService.DeleteCompanyAsync(companyId);

                        // Clear the PictureBox image if it is set
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose(); // Release the resources held by the image
                            pictureBox1.Image = null; // Clear the image from PictureBox
                        }

                        // Refresh the grid
                        await gridDataLoad();

                        // Reset form fields
                        button3_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the company: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            txtCompanyName.Text = "";
            txtAbbreviation.Text = "";
            richTextBox1.Text = "";
            pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg;
            _path = "";
            _fileNameImage = "";
            lblid.Text = "";
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
            txtCompanyName.Focus();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && ValidateForm())
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assume the company ID is stored in the first cell
                int companyId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Get the existing company from the database
                var existingCompany = await _CompanyService.GetCompanyByIdAsync(companyId);

                if (existingCompany != null)
                {
                    string? companyLogo = existingCompany.CompanyLogo;

                    // Check if the user has selected a new image
                    if (pictureBox1.Image != null && !string.IsNullOrEmpty(_fileNameImage))
                    {
                        //----------Set Image For Company Logo --------------//
                        string directoryPath = Path.Combine(Application.StartupPath, "CompanyLogoImg");
                        string fileName = _fileNameImage;

                        // Check if a file with the same name already exists
                        string savePath = Path.Combine(directoryPath, fileName);
                        if (File.Exists(savePath))
                        {
                            // Generate a new unique file name
                            string uniqueFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{Guid.NewGuid()}{Path.GetExtension(fileName)}";
                            savePath = Path.Combine(directoryPath, uniqueFileName);
                            companyLogo = uniqueFileName; // Update companyLogo with the new file name
                        }
                        else
                        {
                            companyLogo = fileName; // Use the original file name
                        }

                        // Create the directory if it doesn't exist
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Save the image with error handling
                        try
                        {
                            using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                            {
                                pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle the exception (e.g., log it, show a message to the user, etc.)
                            MessageBox.Show($"An error occurred while saving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if the image couldn't be saved
                        }
                    }

                    // Update company details
                    existingCompany.CompanyName = txtCompanyName.Text.Trim();
                    existingCompany.Abbreviation = txtAbbreviation.Text.Trim();
                    existingCompany.Remark = richTextBox1.Text.Trim();
                    existingCompany.CompanyLogo = companyLogo; // Update with new logo if any

                    // Save changes to the database
                    await _CompanyService.UpdateCompanyAsync(existingCompany);
                    await gridDataLoad();

                    CustomMessageBox customMessageBox = new CustomMessageBox("Company updated successfully!", "Success", true);
                    customMessageBox.ShowDialog(this);

                    // Clear input fields
                    txtCompanyName.Text = "";
                    txtAbbreviation.Text = "";
                    richTextBox1.Text = "";
                    pictureBox1.Image = null;
                    txtCompanyName.Focus();
                }
                else
                {
                    MessageBox.Show("Selected company could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected or form validation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "output.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dataGridView1, sfd.FileName);
                }
            }
        }
    }
}
