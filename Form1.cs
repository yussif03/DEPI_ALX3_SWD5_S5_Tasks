namespace BonusTask
{
    public partial class Form1 : Form
    {
        #region Vars(s)
        string Name;
        string DOP;
        string Gender;
        string Status;
        string Habites;
        string EnLang;
        string ArLang;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;

            DOP = DTpDOP.Value.ToShortDateString();

            if (RbtnMale.Checked)
                Gender = "Male";
            else
                Gender = "Female";
            //Gender = RbtnMale.Checked ? "Male" : "Female";

            Status = ComoboStatus.Text;

            Habites = string.Empty;
            if (checkBox1.Checked)
            {
                Habites += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                Habites += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                Habites += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                Habites += checkBox4.Text;
            }

            EnLang = progBarEn.Value.ToString();
            ArLang = progBarAr.Value.ToString();

            RtxtRep.Text = string.Format("-------------- Your Information --------------" +
                    "\nName : {0} " +
                    "\n-----------------------------------------------" +
                    "\nBirthday : {1} " +
                    "\n-----------------------------------------------" +
                    "\nGender : {2} " +
                    "\nM Status : {3} " +
                    "\nHabites : {4}" +
                    "\nEnglish Language : {5}" +
                    "\nArabic Language : {6}" +
                    "\n--------------------- End ---------------------"
                    , Name, DOP, Gender, Status, Habites, EnLang, ArLang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void NUDEn_ValueChanged(object sender, EventArgs e)
        {
            progBarEn.Value = (int)NUDEn.Value;
        }

        private void NUDAr_ValueChanged(object sender, EventArgs e)
        {
            progBarAr.Value = (int)NUDAr.Value;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RtxtRep.Text, new Font("Tahoma", 16), Brushes.Blue, 10, 10);
        }
    }
}
