namespace AWMS.app.Utility
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OK = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // OK
            // 
            OK.Location = new Point(109, 106);
            OK.Name = "OK";
            OK.Size = new Size(106, 38);
            OK.TabIndex = 0;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 1;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 162);
            Controls.Add(label1);
            Controls.Add(OK);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK;
        private Label label1;
    }
}