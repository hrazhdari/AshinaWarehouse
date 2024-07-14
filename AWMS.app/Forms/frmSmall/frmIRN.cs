using AWMS.core.Interfaces;
using AWMS.dto;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmIRN : XtraForm
    {
        private readonly IIrnService _irnService;
        public event EventHandler IRNRecordAdded;
        bool EventHandler;
        public frmIRN(IIrnService irnService,bool attachEventHandler = true)
        {
            InitializeComponent();
            lblIRNEnterDate.Text = DateTime.Now.ToString();
            this._irnService = irnService;

            EventHandler = attachEventHandler;
        }
        private async void btnAddIRN_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 10;

            string irnName = txtIRNName.Text.Trim();
            string irnDescription = txtIRNDescription.Text.Trim();
            DateTime enteredDate = IRNDate.DateTime != DateTime.MinValue ? IRNDate.DateTime : DateTime.Now;

            if (string.IsNullOrWhiteSpace(irnName))
            {
                MessageBox.Show("Please enter a valid IRN Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate mrName
            bool duplicateRowHandle = await _irnService.ExistsByIrnNameAsync(irnName);

            if (duplicateRowHandle != false)
            {
                MessageBox.Show("IRN Name already exists. Please enter a unique IRN Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var newIrn = new IrnDto()
            {
                IrnName = irnName,
                IrnDescription = irnDescription,
                EnteredDate = enteredDate
            };

            btnAddIRN.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await _irnService.AddIrnAsync(newIrn);

            btnAddIRN.Enabled = true;

            if (isAdded>0)
            {
                XtraMessageBox.Show("IRN record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;

                if (EventHandler)
                {
                    IRNRecordAdded?.Invoke(this, EventArgs.Empty);
                }
                //this.Close(); // Close the form after adding the IRN record

            }
            else
            {
                XtraMessageBox.Show("Failed to add IRN record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
