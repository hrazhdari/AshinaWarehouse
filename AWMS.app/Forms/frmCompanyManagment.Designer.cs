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
            button1 = new Button();
            txtCompanyName = new TextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            txtAbbreviation = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btndelete = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btnExcelSave = new Button();
            button5 = new Button();
            groupBox3 = new GroupBox();
            lblid = new Label();
            errorProvider1 = new ErrorProvider(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_add_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(16, 19);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 40);
            button1.TabIndex = 0;
            button1.Text = "Add Company";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            txtCompanyName.Location = new Point(134, 14);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(337, 24);
            txtCompanyName.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(134, 82);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(337, 105);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.No_Image_Placeholder_svg;
            pictureBox1.Location = new Point(583, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 6;
            label1.Text = "Company Name :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(583, 173);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(179, 14);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Select Logo For Company ...";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            label2.Location = new Point(19, 50);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 9;
            label2.Text = "Abbreviation :";
            // 
            // txtAbbreviation
            // 
            txtAbbreviation.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            txtAbbreviation.Location = new Point(134, 47);
            txtAbbreviation.Margin = new Padding(3, 2, 3, 2);
            txtAbbreviation.Name = "txtAbbreviation";
            txtAbbreviation.Size = new Size(337, 24);
            txtAbbreviation.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            label3.Location = new Point(19, 82);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 11;
            label3.Text = "Remark :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(11, 214);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(579, 70);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.PaleVioletRed;
            btndelete.Cursor = Cursors.Hand;
            btndelete.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Image = Properties.Resources.icons8_delete_321;
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(312, 19);
            btndelete.Margin = new Padding(3, 2, 3, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(137, 40);
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
            button3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.icons8_delete_view_32;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(471, 19);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 40);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Cursor = Cursors.Hand;
            button2.Enabled = false;
            button2.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.icons8_edit_32;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(165, 19);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 1;
            button2.Text = "Edit Company";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExcelSave);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(10, 1);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(825, 292);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnExcelSave
            // 
            btnExcelSave.Cursor = Cursors.Hand;
            btnExcelSave.Image = Properties.Resources.icons8_microsoft_excel_2019_32;
            btnExcelSave.Location = new Point(707, 233);
            btnExcelSave.Margin = new Padding(3, 2, 3, 2);
            btnExcelSave.Name = "btnExcelSave";
            btnExcelSave.Size = new Size(41, 40);
            btnExcelSave.TabIndex = 13;
            btnExcelSave.UseVisualStyleBackColor = true;
            btnExcelSave.Click += btnExcelSave_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Image = Properties.Resources.icons8_return_16;
            button5.Location = new Point(769, 233);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(41, 40);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAbbreviation);
            groupBox3.Controls.Add(lblid);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(txtCompanyName);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(11, 10);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(0);
            groupBox3.Size = new Size(797, 201);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.Gray;
            lblid.ForeColor = SystemColors.ButtonFace;
            lblid.Location = new Point(16, 174);
            lblid.Name = "lblid";
            lblid.Size = new Size(25, 13);
            lblid.TabIndex = 13;
            lblid.Text = "ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(846, 408);
            dataGridView1.TabIndex = 14;
            // 
            // frmCompanyManagment
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 706);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Name = "frmCompanyManagment";
            Text = "Company Management";
            Load += frmCompanyManagment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TextBox txtCompanyName;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox txtAbbreviation;
        private Label label3;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button btndelete;
        private GroupBox groupBox2;
        private Label lblid;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox3;
        private Button button5;
        private DataGridView dataGridView1;
        private Button btnExcelSave;
    }
}