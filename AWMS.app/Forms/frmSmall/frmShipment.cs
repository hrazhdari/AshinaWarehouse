using AWMS.core.Interfaces;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using AWMS.dto;
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
    public partial class frmShipment : XtraForm
    {
        private readonly IPoService _poService;
        private readonly IShipmentService _shipmentService;
        public event EventHandler ShipRecordAdded;
        bool EventHandler;
        public frmShipment(IPoService poService, IShipmentService shipmentService,
            bool attachEventHandler = true)
        {
            InitializeComponent();
            lblIRNEnterDate.Text = DateTime.Now.ToString();
            this._poService = poService;
            this._shipmentService = shipmentService;
            EventHandler = attachEventHandler;
            LoadPO();
        }
        private async void LoadPO()
        {
            lookUpEditPo.Properties.DataSource=await _poService.GetAllPosAsync();
        }
        private async void btnAddShipment_Click(object sender, EventArgs e)
        {

            progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.Properties.Step = 10;

            string ShipmentName = txtShipmentName.Text.Trim();
            int poid = (lookUpEditPo.EditValue as int?) ?? 1;
            string ShipmentDescription = txtShipmentDescription.Text.Trim();
            DateTime enteredDate = ShipmentDate.DateTime != DateTime.MinValue ? ShipmentDate.DateTime : DateTime.Now;

            if (string.IsNullOrWhiteSpace(ShipmentName))
            {
                MessageBox.Show("Please enter a valid Shipment Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate mrName
            bool duplicateRowHandle = await _shipmentService.ExistsShipmentByShipmentNameAsync(ShipmentName);

            if (duplicateRowHandle != false)
            {
                MessageBox.Show("Shipment Name already exists. Please enter a unique Shipment Name.", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newShipment = new ShipmentDto()
            {
                ShipmentName = ShipmentName,
                PoId = poid,
                ShipmentDescription = ShipmentDescription,
                EnteredDate = enteredDate
            };

            btnAddShipment.Enabled = false;

            await UpdateProgressBarAsync();

            int isAdded = await _shipmentService.AddShipmentAsync(newShipment);

            btnAddShipment.Enabled = true;

            if (isAdded > 0)
            {
                XtraMessageBox.Show("Shipment record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarControl1.Position = 0;
                if (EventHandler)
                {
                    ShipRecordAdded?.Invoke(this, EventArgs.Empty);
                }

            }
            else
            {
                XtraMessageBox.Show("Failed to add Shipment record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
