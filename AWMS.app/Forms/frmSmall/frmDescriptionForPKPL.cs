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
    public partial class frmDescriptionForPKPL : XtraForm
    {
        private readonly IDescriptionForPkService _descriptionForPkService;
        public event EventHandler DesRecordAdded;
        bool EventHandler;
     
        public frmDescriptionForPKPL(IDescriptionForPkService DescriptionForPkService,bool attachEventHandler = true)
        {
            InitializeComponent();
            this._descriptionForPkService = DescriptionForPkService;
            EventHandler = attachEventHandler;
        }

        private async void btnAddDescription_Click(object sender, EventArgs e)
        {

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 1;

            string Descriptionpk = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(Descriptionpk))
            {
                MessageBox.Show("Please enter a valid Description Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            var newDescriptionForPk = new DescriptionForPkDto()
            {
                Description = Descriptionpk,
            };

            btnAddDescription.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await AddDesRecordAsync(newDescriptionForPk);

            btnAddDescription.Enabled = true;

            if (isAdded>0)
            {
                XtraMessageBox.Show("Description record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;

                if (EventHandler)
                {
                    DesRecordAdded?.Invoke(this, EventArgs.Empty);
                }

            }
            else
            {
                XtraMessageBox.Show("Failed to add Description record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progressBarControl1.Position = 0;
            }
        }
        private async Task UpdateProgressBarAsync()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBarControl1.Position = i;

                // Simulate a small delay without blocking the UI
                await Task.Delay(5); // Adjust the delay time if needed
            }
        }
        private async Task<int> AddDesRecordAsync(DescriptionForPkDto newDescriptionForPk)
        {
            try
            {
                // Add the DescriptionForPK record to the database asynchronously
                return await Task.Run(() => _descriptionForPkService.AddDescriptionForPkAsync(newDescriptionForPk));
            }
            catch (Exception)
            {
                // Handle exception (log, throw, etc.)
                return -1;
            }
        }

    }
}
