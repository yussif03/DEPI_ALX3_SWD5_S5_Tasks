
using Task6.Models;

namespace Task6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblName = new Label();
            lblJob = new Label();
            lblSalary = new Label();
            txtName = new TextBox();
            txtJob = new TextBox();
            txtSalary = new TextBox();
            lblcmbName = new Label();
            cmbName = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSave = new Button();
            BtnEdit = new Button();
            btnDelete = new Button();
            picEmployee = new PictureBox();
            btnShow = new Button();
            dgvEmployees = new DataGridView();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(53, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID :";
            lblId.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name :";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(45, 124);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(39, 20);
            lblJob.TabIndex = 2;
            lblJob.Text = "Job :";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(28, 172);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(56, 20);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary :";
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 4;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(90, 121);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(282, 27);
            txtJob.TabIndex = 5;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(90, 169);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(282, 27);
            txtSalary.TabIndex = 6;
            // 
            // lblcmbName
            // 
            lblcmbName.AutoSize = true;
            lblcmbName.Location = new Point(34, 297);
            lblcmbName.Name = "lblcmbName";
            lblcmbName.Size = new Size(56, 20);
            lblcmbName.TabIndex = 7;
            lblcmbName.Text = "Name :";
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(34, 320);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(270, 28);
            cmbName.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(332, 297);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            lblSearch.Click += label6_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(332, 321);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 27);
            txtSearch.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ScrollBar;
            btnSave.Location = new Point(34, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = SystemColors.ScrollBar;
            BtnEdit.Location = new Point(128, 371);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(82, 29);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.Location = new Point(222, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // picEmployee
            // 
            picEmployee.Location = new Point(439, 28);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(268, 218);
            picEmployee.TabIndex = 14;
            picEmployee.TabStop = false;
            picEmployee.Click += picBox_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.ScrollBar;
            btnShow.Location = new Point(625, 319);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(82, 29);
            btnShow.TabIndex = 15;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 417);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(717, 269);
            dgvEmployees.TabIndex = 16;
            dgvEmployees.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ScrollBar;
            btnBrowse.Location = new Point(532, 252);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(82, 29);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 698);
            Controls.Add(btnBrowse);
            Controls.Add(dgvEmployees);
            Controls.Add(btnShow);
            Controls.Add(picEmployee);
            Controls.Add(btnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(cmbName);
            Controls.Add(lblcmbName);
            Controls.Add(txtSalary);
            Controls.Add(txtJob);
            Controls.Add(txtName);
            Controls.Add(lblSalary);
            Controls.Add(lblJob);
            Controls.Add(lblName);
            Controls.Add(lblId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblJob;
        private Label lblSalary;
        private TextBox txtName;
        private TextBox txtJob;
        private TextBox txtSalary;
        private Label lblcmbName;
        private ComboBox cmbName;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSave;
        private Button BtnEdit;
        private Button btnDelete;
        private PictureBox picEmployee;
        private Button btnShow;
        private DataGridView dgvEmployees;
        private Button btnBrowse;
    }
}
