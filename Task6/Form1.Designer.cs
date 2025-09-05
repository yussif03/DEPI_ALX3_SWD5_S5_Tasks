
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
            lblID = new Label();
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
            picEmployee = new PictureBox();
            dgvEmployees = new DataGridView();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnShow = new Button();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(52, 32);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name :";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(44, 128);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(39, 20);
            lblJob.TabIndex = 2;
            lblJob.Text = "Job :";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(27, 176);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(56, 20);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary :";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 27);
            txtName.TabIndex = 4;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(98, 125);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(262, 27);
            txtJob.TabIndex = 5;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(98, 173);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(262, 27);
            txtSalary.TabIndex = 6;
            // 
            // lblcmbName
            // 
            lblcmbName.AutoSize = true;
            lblcmbName.Location = new Point(33, 291);
            lblcmbName.Name = "lblcmbName";
            lblcmbName.Size = new Size(56, 20);
            lblcmbName.TabIndex = 7;
            lblcmbName.Text = "Name :";
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(33, 313);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(262, 28);
            cmbName.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(336, 291);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(336, 314);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(262, 27);
            txtSearch.TabIndex = 10;
            // 
            // picEmployee
            // 
            picEmployee.Location = new Point(430, 32);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(258, 210);
            picEmployee.TabIndex = 11;
            picEmployee.TabStop = false;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 411);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(711, 259);
            dgvEmployees.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Menu;
            btnSave.Location = new Point(33, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Menu;
            btnEdit.Location = new Point(125, 359);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Menu;
            btnDelete.Location = new Point(217, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.Menu;
            btnShow.Location = new Point(610, 313);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(78, 29);
            btnShow.TabIndex = 16;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.Menu;
            btnBrowse.Location = new Point(540, 248);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(78, 29);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 682);
            Controls.Add(btnBrowse);
            Controls.Add(btnShow);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(dgvEmployees);
            Controls.Add(picEmployee);
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
            Controls.Add(lblID);
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
            LoadEmployees();
        }

        #endregion

        private Label lblID;
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
        private PictureBox picEmployee;
        private DataGridView dgvEmployees;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnShow;
        private Button btnBrowse;
    }
}
