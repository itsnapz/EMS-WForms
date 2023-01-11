using EMS_RS.Models;
using EMS_RS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_RS.Forms
{
    public partial class DoctorItemEditForm : Form
    {
        private DoctorModel _doctor { get; set; }
        private DatabaseService _service;
        private List<HospitalModel> _hospitals;
        private HospitalModel _hospital { get; set; }
        public DoctorItemEditForm(DatabaseService service, DoctorModel doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _service = service;
            _hospitals = new();
        }

        private void DoctorItemEditForm_Load(object sender, EventArgs e)
        {
            _cmbHospital.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbRank.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;

            _hospitals = _service.GetHospitals().ToList();

            _cmbHospital.Items.Clear();

            foreach (var hospital in _hospitals)
            {
                _cmbHospital.Items.Add(hospital.Name);
            }
            _hospital = _service.GetHospital(_doctor.Hospital_Id);
            _txtName.Text = _doctor.Name;
            _txtSurname.Text = _doctor.Surname;
            _txtPhone.Text = _doctor.Phone_Number.ToString();
            _txtPassword.Text = _doctor.Password;
            _txtCallSign.Text = _doctor.Call_Sign;
            dateTimePicker1.Value = _doctor.Birthday;
            _cmbSex.SelectedItem = _doctor.Sex;
            _cmbRank.SelectedItem = _doctor.Rank;
            _cmbHospital.SelectedItem = _hospital.Name;
            string name = _cmbHospital.SelectedItem.ToString();
            _hospital = _hospitals.FirstOrDefault(x => x.Name == name);
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            DoctorModel model = new()
            {
                Name = _txtName.Text,
                Surname = _txtSurname.Text,
                Sex = _cmbSex.SelectedItem.ToString(),
                Rank = _cmbRank.SelectedItem.ToString(),
                Phone_Number = int.Parse(_txtPhone.Text),
                Hospital_Id = _hospital.Hospital_Id,
                Password = _txtPassword.Text,
                Call_Sign = _txtCallSign.Text,
                Birthday = dateTimePicker1.Value.Date,
            };
            _service.UpdateDoctor(model, _doctor.Doctor_Id);
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _cmbHospital_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_cmbHospital != null)
            {
                string hospitalName = _cmbHospital.SelectedItem.ToString();
                _hospital = _hospitals.FirstOrDefault(x => x.Name == hospitalName);
            }
        }
    }
}
