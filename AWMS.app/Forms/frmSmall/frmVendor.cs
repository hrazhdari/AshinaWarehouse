using AWMS.core.Interfaces;
using AWMS.dto;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AWMS.app.Forms.frmSmall
{
    public partial class frmVendor : frmBase.frmBase
    {
        private readonly IVendorService _vendorService;
        public event EventHandler VendorRecordAdded;
        bool EventHandler;
        public frmVendor(IVendorService vendorService ,bool attachEventHandler = true)
        {
            InitializeComponent();
            lblVendorEnterDate.Text = DateTime.Now.ToString();
            this._vendorService = vendorService;

            EventHandler = attachEventHandler;
        }

        private async void btnAddVendor_Click(object sender, EventArgs e)
        {

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 10;

            string VendorName = txtVendorName.Text.Trim();
            string VendorAbbreviation = txtVendorAbbreviation.Text.Trim();
            string VendorContractDescription = txtVendorContractDescription.Text.Trim();
            string VendorContractor = txtVendorContractor.Text.Trim();
            string VendorRemark = txtVendorRemark.Text.Trim();
            int LocalForeign = radioGroup1.SelectedIndex != -1 ? radioGroup1.SelectedIndex+1 : 1;
            DateTime enteredDate = VendorDate.DateTime != DateTime.MinValue ? VendorDate.DateTime : DateTime.Now;

            if (string.IsNullOrWhiteSpace(VendorName))
            {
                MessageBox.Show("Please enter a valid Vendor Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate mrName
            bool duplicateRowHandle = await _vendorService.ExistsVendorAsync(VendorName);

            if (duplicateRowHandle != false)
            {
                MessageBox.Show("Vendor Name already exists. Please enter a unique Vendor Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newVendor = new VendorDto()
            {
                VendorName = VendorName,
                VendorAbbreviation = VendorAbbreviation,    
                VendorContractDescription = VendorContractDescription,
                VendorContractNO= VendorContractor,
                Remark= VendorRemark,
                Local_Foreign = LocalForeign,
                EnteredDate = enteredDate
            };

            btnAddVendor.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await _vendorService.AddVendorAsync(newVendor);

            btnAddVendor.Enabled = true;

            if (isAdded>0)
            {
                XtraMessageBox.Show("Vendor record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;
                if (EventHandler)
                {
                    VendorRecordAdded?.Invoke(this, EventArgs.Empty);
                }

            }
            else
            {
                XtraMessageBox.Show("Failed to add Vendor record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;
            }
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i+=10)
            {
                progressBarControl1.Position = i;

                // Simulate a small delay without blocking the UI
                await Task.Delay(10); // Adjust the delay time if needed
            }
        }
    }
}
