using EMS_RS.Forms;
using EMS_RS.Models;
using EMS_RS.Services;

namespace EMS_RS
{
    public partial class Form1 : Form
    {
        public readonly DatabaseService _service;
        private List<DoctorModel> _doctors;
        public Form1()
        {
            InitializeComponent();
            _service = new();
            _doctors = new List<DoctorModel>();

            _service.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            var doctors = _service.GetDoctors();
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
                    _cmbDoctors.Items.Add(doc.Name + " " + doc.Surname);
                }
            }
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            string password = _txtPassword.Text;
            var name = _cmbDoctors.SelectedItem;
            var user = _doctors.FirstOrDefault(x => x.Name + " " + x.Surname == name.ToString());
            if (user != null)
            {
                if (user.Password == password)
                {
                    Hide();
                    MainForm MainForm = new(_service ,user);
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show("I'm sorry");
                }
            }
            else
            {
                MessageBox.Show("No user selected.");
            }
        }
    }
}