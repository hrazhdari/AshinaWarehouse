namespace AWMS.app.Forms.RibbonVoucher
{
    partial class frmPrint
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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "simpleButton1";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // documentViewer1
            // 
            documentViewer1.IsMetric = false;
            documentViewer1.Location = new Point(93, 305);
            documentViewer1.Name = "documentViewer1";
            documentViewer1.Size = new Size(695, 133);
            documentViewer1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(12, 41);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "simpleButton2";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // pdfViewer1
            // 
            pdfViewer1.Location = new Point(135, 12);
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.Size = new Size(653, 287);
            pdfViewer1.TabIndex = 3;
            // 
            // frmPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pdfViewer1);
            Controls.Add(simpleButton2);
            Controls.Add(documentViewer1);
            Controls.Add(simpleButton1);
            Name = "frmPrint";
            Text = "forv";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
    }
}