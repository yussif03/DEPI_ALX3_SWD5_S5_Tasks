using Task6.Models;

namespace Task6
{
    public partial class Form1 : Form
    {

        private GenericIRepository<Employee> _employeeRepo;

        public Form1()
        {
            InitializeComponent();
            _employeeRepo = new Repository<Employee>(new EmployeeDbContext());
            LoadEmployees();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picEmployee.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                Name = txtName.Text,
                Job = txtJob.Text,
                Salary = decimal.Parse(txtSalary.Text),
                Photo = ImageToByte(picEmployee.Image)
            };

            _employeeRepo.Add(emp);
            _employeeRepo.Save();
            MessageBox.Show("Employee Saved!");
            LoadEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            var emp = _employeeRepo.GetById(id);

            if (emp != null)
            {
                emp.Name = txtName.Text;
                emp.Job = txtJob.Text;
                emp.Salary = decimal.Parse(txtSalary.Text);
                emp.Photo = ImageToByte(picEmployee.Image);

                _employeeRepo.Update(emp);
                _employeeRepo.Save();
                MessageBox.Show("Employee Updated!");
                LoadEmployees();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            _employeeRepo.Delete(id);
            _employeeRepo.Save();
            MessageBox.Show("Employee Deleted!");
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = _employeeRepo.GetAll()
                .Select(x => new { x.Id, x.Name, x.Job, x.Salary })
                .ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            dgvEmployees.DataSource = _employeeRepo.GetAll()
                .Where(x => x.Name.Contains(keyword))
                .Select(x => new { x.Id, x.Name, x.Job, x.Salary })
                .ToList();
        }

        private byte[] ImageToByte(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteToImage(byte[] byteArray)
        {
            if (byteArray == null) return null;
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
