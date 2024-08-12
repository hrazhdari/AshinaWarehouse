namespace AWMS.app.Forms
{
    partial class frmCompanyManagment
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyManagment));
            errorProvider1 = new ErrorProvider(components);
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            button5 = new Button();
            btndelete = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            txtAbbreviation = new TextBox();
            btnExcelSave = new Button();
            lblid = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            txtCompanyName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1056, 765);
            splitContainer1.SplitterDistance = 383;
            splitContainer1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(879, 36);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(165, 216);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Image = Properties.Resources.icons8_return_16;
            button5.Location = new Point(112, 159);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(41, 43);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.PaleVioletRed;
            btndelete.Cursor = Cursors.Hand;
            btndelete.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Image = Properties.Resources.icons8_delete_321;
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(16, 113);
            btndelete.Margin = new Padding(3, 2, 3, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(137, 43);
            btndelete.TabIndex = 2;
            btndelete.Text = "Delete Company";
            btndelete.TextAlign = ContentAlignment.MiddleRight;
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.icons8_delete_view_32;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(16, 160);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 43);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Cursor = Cursors.Hand;
            button2.Enabled = false;
            button2.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.icons8_edit_32;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(21, 66);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(125, 43);
            button2.TabIndex = 1;
            button2.Text = "Edit Company";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_add_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(19, 19);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 0;
            button1.Text = "Add Company";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(27, 24);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(825, 236);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(txtAbbreviation);
            groupBox3.Controls.Add(btnExcelSave);
            groupBox3.Controls.Add(lblid);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(txtCompanyName);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(11, 11);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(0);
            groupBox3.Size = new Size(797, 218);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Image = Properties.Resources.icons8_synchronize_32;
            button4.Location = new Point(498, 152);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(41, 43);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtAbbreviation
            // 
            txtAbbreviation.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAbbreviation.Location = new Point(134, 51);
            txtAbbreviation.Margin = new Padding(3, 2, 3, 2);
            txtAbbreviation.Name = "txtAbbreviation";
            txtAbbreviation.Size = new Size(337, 24);
            txtAbbreviation.TabIndex = 1;
            // 
            // btnExcelSave
            // 
            btnExcelSave.Cursor = Cursors.Hand;
            btnExcelSave.Image = Properties.Resources.icons8_microsoft_excel_2019_32;
            btnExcelSave.Location = new Point(498, 105);
            btnExcelSave.Margin = new Padding(3, 2, 3, 2);
            btnExcelSave.Name = "btnExcelSave";
            btnExcelSave.Size = new Size(41, 43);
            btnExcelSave.TabIndex = 13;
            btnExcelSave.UseVisualStyleBackColor = true;
            btnExcelSave.Click += btnExcelSave_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.Gray;
            lblid.ForeColor = SystemColors.ButtonFace;
            lblid.Location = new Point(10, 182);
            lblid.Name = "lblid";
            lblid.Size = new Size(25, 13);
            lblid.TabIndex = 13;
            lblid.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 9;
            label2.Text = "Abbreviation :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(577, 181);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(179, 14);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Select Logo For Company ...";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(134, 15);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(337, 24);
            txtCompanyName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg;
            pictureBox1.Location = new Point(583, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 6;
            label1.Text = "Company Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 114);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 11;
            label3.Text = "Remark :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(134, 89);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(337, 113);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1056, 378);
            dataGridView1.TabIndex = 19;
            // 
            // frmCompanyManagment
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 765);
            Controls.Add(splitContainer1);
            IconOptions.Icon = (Icon)resources.GetObject("frmCompanyManagment.IconOptions.Icon");
            Name = "frmCompanyManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Management";
            Load += frmCompanyManagment_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnExcelSave;
        private Button button5;
        private GroupBox groupBox3;
        private TextBox txtAbbreviation;
        private Label lblid;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox txtCompanyName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Button btndelete;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}