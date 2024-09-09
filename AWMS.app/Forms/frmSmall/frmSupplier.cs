using AWMS.core.Interfaces;
using AWMS.dto;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Forms.frmSmall
{
    public partial class frmSupplier : XtraForm
    {
        private readonly ISupplierService _supplierService;
        public event EventHandler SupplierRecordAdded;
        bool EventHandler;
        public frmSupplier(ISupplierService supplierService ,bool attachEventHandler = true)
        {
            InitializeComponent();
            lblSuplierEnterDate.Text = DateTime.Now.ToString();
            this._supplierService = supplierService;
            EventHandler = attachEventHandler;
        }

        private async void btnAddSupplier_Click(object sender, EventArgs e)
        {
                progressBarControl1.Properties.Maximum = 100;
                progressBarControl1.Properties.Step = 10;

                string SupplierName = txtSupplierName.Text.Trim();
                string SupplierRemark = txtSupplierDescription.Text.Trim();
                DateTime enteredDate = SupplierDate.DateTime != DateTime.MinValue ? SupplierDate.DateTime : DateTime.Now;

                if (string.IsNullOrWhiteSpace(SupplierName))
                {
                    MessageBox.Show("Please enter a valid Supplier Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check for duplicate mrName
                bool duplicateRowHandle = await _supplierService.ExistsSupplierAsync(SupplierName);

                if (duplicateRowHandle != false)
                {
                    MessageBox.Show("Supplier Name already exists. Please enter a unique Supplier Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSupplier = new SupplierDto()
                {
                    SupplierName = SupplierName,
                    SupplierRemark = SupplierRemark,
                    EnteredDate = enteredDate
                };

                btnAddSupplier.Enabled = false;

                await UpdateProgressBarAsync();

                int isAdded = await _supplierService.AddSupplierAsync(newSupplier);

                btnAddSupplier.Enabled = true;

                if (isAdded>0)
                {
                    XtraMessageBox.Show("Supplier record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    progressBarControl1.Position = 0;
                    if (EventHandler)
                    {
                        SupplierRecordAdded?.Invoke(this, EventArgs.Empty);
                    }

                }
                else
                {
                    XtraMessageBox.Show("Failed to add Supplier record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
