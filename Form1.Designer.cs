namespace BonusTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtName = new TextBox();
            DTpDOP = new DateTimePicker();
            RbtnMale = new RadioButton();
            RbtnFemale = new RadioButton();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label6 = new Label();
            btnRes = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ComoboStatus = new ComboBox();
            NUDEn = new NumericUpDown();
            NUDAr = new NumericUpDown();
            progBarEn = new ProgressBar();
            label3 = new Label();
            label5 = new Label();
            progBarAr = new ProgressBar();
            groupBox3 = new GroupBox();
            btnPrint = new Button();
            btnPrev = new Button();
            btnSetup = new Button();
            RtxtRep = new RichTextBox();
            label1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDAr).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Birthday :";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 0;
            // 
            // DTpDOP
            // 
            DTpDOP.CustomFormat = "dd/MM/yyyy";
            DTpDOP.Format = DateTimePickerFormat.Custom;
            DTpDOP.Location = new Point(130, 73);
            DTpDOP.Name = "DTpDOP";
            DTpDOP.Size = new Size(242, 27);
            DTpDOP.TabIndex = 1;
            // 
            // RbtnMale
            // 
            RbtnMale.AutoSize = true;
            RbtnMale.Checked = true;
            RbtnMale.Location = new Point(39, 37);
            RbtnMale.Name = "RbtnMale";
            RbtnMale.Size = new Size(63, 24);
            RbtnMale.TabIndex = 0;
            RbtnMale.TabStop = true;
            RbtnMale.Text = "Male";
            RbtnMale.UseVisualStyleBackColor = true;
            // 
            // RbtnFemale
            // 
            RbtnFemale.AutoSize = true;
            RbtnFemale.Location = new Point(208, 37);
            RbtnFemale.Name = "RbtnFemale";
            RbtnFemale.Size = new Size(78, 24);
            RbtnFemale.TabIndex = 1;
            RbtnFemale.Text = "Female";
            RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 245);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Mstatus :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Football";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(208, 33);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Watch TV";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(48, 66);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(122, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Programming";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(208, 66);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Gaming";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 426);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 13;
            label6.Text = "English :";
            // 
            // btnRes
            // 
            btnRes.Location = new Point(145, 526);
            btnRes.Name = "btnRes";
            btnRes.Size = new Size(131, 46);
            btnRes.TabIndex = 7;
            btnRes.Text = "Show Result";
            btnRes.UseVisualStyleBackColor = true;
            btnRes.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 477);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 15;
            label7.Text = "Arabic :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbtnMale);
            groupBox1.Controls.Add(RbtnFemale);
            groupBox1.Location = new Point(42, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 87);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Location = new Point(42, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 111);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habites :";
            // 
            // ComoboStatus
            // 
            ComoboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComoboStatus.FormattingEnabled = true;
            ComoboStatus.Items.AddRange(new object[] { "أعزب", "متزوج", "أرمل", "مطلق" });
            ComoboStatus.Location = new Point(130, 241);
            ComoboStatus.Name = "ComoboStatus";
            ComoboStatus.Size = new Size(242, 28);
            ComoboStatus.TabIndex = 2;
            // 
            // NUDEn
            // 
            NUDEn.Location = new Point(111, 423);
            NUDEn.Name = "NUDEn";
            NUDEn.Size = new Size(57, 27);
            NUDEn.TabIndex = 3;
            NUDEn.ValueChanged += NUDEn_ValueChanged;
            // 
            // NUDAr
            // 
            NUDAr.Location = new Point(111, 474);
            NUDAr.Name = "NUDAr";
            NUDAr.Size = new Size(57, 27);
            NUDAr.TabIndex = 5;
            NUDAr.ValueChanged += NUDAr_ValueChanged;
            // 
            // progBarEn
            // 
            progBarEn.Location = new Point(201, 422);
            progBarEn.Name = "progBarEn";
            progBarEn.Size = new Size(171, 29);
            progBarEn.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 426);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 22;
            label3.Text = "%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 477);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 23;
            label5.Text = "%";
            // 
            // progBarAr
            // 
            progBarAr.Location = new Point(201, 473);
            progBarAr.Name = "progBarAr";
            progBarAr.Size = new Size(171, 29);
            progBarAr.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPrint);
            groupBox3.Controls.Add(btnPrev);
            groupBox3.Controls.Add(btnSetup);
            groupBox3.Controls.Add(RtxtRep);
            groupBox3.Location = new Point(396, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 560);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Report";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(221, 517);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(118, 517);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "Preview";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += button3_Click;
            // 
            // btnSetup
            // 
            btnSetup.Location = new Point(15, 517);
            btnSetup.Name = "btnSetup";
            btnSetup.Size = new Size(94, 29);
            btnSetup.TabIndex = 0;
            btnSetup.Text = "Page setup";
            btnSetup.UseVisualStyleBackColor = true;
            btnSetup.Click += btnSetup_Click;
            // 
            // RtxtRep
            // 
            RtxtRep.Location = new Point(15, 31);
            RtxtRep.Name = "RtxtRep";
            RtxtRep.ScrollBars = RichTextBoxScrollBars.None;
            RtxtRep.Size = new Size(301, 447);
            RtxtRep.TabIndex = 0;
            RtxtRep.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 29);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 26;
            label1.Text = "Name :";
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 612);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(progBarAr);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(progBarEn);
            Controls.Add(NUDAr);
            Controls.Add(NUDEn);
            Controls.Add(ComoboStatus);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btnRes);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(DTpDOP);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDEn).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDAr).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtName;
        private DateTimePicker DTpDOP;
        private RadioButton RbtnMale;
        private RadioButton RbtnFemale;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label6;
        private Button btnRes;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox ComoboStatus;
        private NumericUpDown NUDEn;
        private NumericUpDown NUDAr;
        private ProgressBar progBarEn;
        private Label label3;
        private Label label5;
        private ProgressBar progBarAr;
        private GroupBox groupBox3;
        private Button btnPrint;
        private Button btnPrev;
        private Button btnSetup;
        private RichTextBox RtxtRep;
        private Label label1;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
