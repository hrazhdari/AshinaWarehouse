using DevExpress.XtraEditors;
using System;
using AWMS.dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWMS.core.Interfaces;

namespace AWMS.app.Forms.frmSmall
{
    public partial class frmAreaUnit : XtraForm
    {
        private readonly IAreaUnitService _areaUnitService;
        public event EventHandler AreaRecordAdded;
        bool EventHandler;
        public frmAreaUnit(IAreaUnitService areaUnitService ,bool attachEventHandler = true)
        {
            InitializeComponent();
            lblAreaEnterDate.Text = DateTime.Now.ToString();
            this._areaUnitService = areaUnitService;
            EventHandler = attachEventHandler;
        }

        private async void btnAddAreaUnit_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 1;

            string AreaunitName = txtAreaName.Text.Trim();
            string Areaunitrain = txtAreaTrain.Text.Trim();
            string AreaunitDescription = txtAreaDescription.Text.Trim();
            string Areaunitremark = txtAreaRemark.Text.Trim();
            DateTime enteredDate = AreaDate.DateTime != DateTime.MinValue ? AreaDate.DateTime : DateTime.Now;

            if (string.IsNullOrWhiteSpace(AreaunitName))
            {
                MessageBox.Show("Please enter a valid Areaunit Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate mrName
            bool duplicateRowHandle = await _areaUnitService.ExistsAreaUnitAsync(AreaunitName);

            if (duplicateRowHandle != false)
            {
                MessageBox.Show("Areaunit Name already exists. Please enter a unique Areaunit Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newAreaunit = new AreaUnitDto()
            {
                AreaUnitName = AreaunitName,
                AreaUnitTrain=Areaunitrain,
                AreaUnitDescription = AreaunitDescription,
                Remark = Areaunitremark,
                EnteredDate = enteredDate
            };

            btnAddAreaUnit.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await _areaUnitService.AddAreaUnitAsync(newAreaunit);

            btnAddAreaUnit.Enabled = true;

            if (isAdded>0)
            {
                XtraMessageBox.Show("Areaunit record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;
                if (EventHandler)
                {
                    AreaRecordAdded?.Invoke(this, EventArgs.Empty);
                }

            }
            else
            {
                XtraMessageBox.Show("Failed to add Areaunit record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
