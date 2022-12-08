using EMS_RS.Data;
using Microsoft.EntityFrameworkCore;

namespace EMS_RS
{
    public partial class Form1 : Form
    {
        EmsDbContext _database;
        private List<Doctor> _doctors;
        public Form1()
        {
            InitializeComponent();
            _database = new();
            _doctors = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var doctors = _database.Doctors;
            if (doctors == null)
            {
                MessageBox.Show("Can't load doctors¨.");
            }
            else
            {
                _doctors = doctors.ToList();
                _cmbDoctors.Items.Clear();
                foreach (var doc in _doctors)
                {
                    _cmbDoctors.Items.Add(doc.Name);
                }
            }
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            string inputPw = _txtPassword.Text;
        }
    }
}