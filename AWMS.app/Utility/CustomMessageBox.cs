using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWMS.app.Utility
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title,bool result)
        {
            InitializeComponent();

            // Set the message and title
            this.Text = title;
            this.label1.Text = message;
            if (result) { label1.ForeColor = Color.DarkOliveGreen; } else { label1.ForeColor = Color.OrangeRed; }
            // Set the form to be shown as a dialog and center it to the parent form
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
