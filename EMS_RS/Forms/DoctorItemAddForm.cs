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
    public partial class DoctorItemAddForm : Form
    {
        private DatabaseService _service;
        private List<HospitalModel> _hospitals;
        private HospitalModel _hospital { get; set; }
        public DoctorItemAddForm(DatabaseService service)
        {
            InitializeComponent();
            _service = service;
            _hospitals = new List<HospitalModel>();
        }

        private void DoctorItemAddForm_Load(object sender, EventArgs e)
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
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_txtName.Text != string.Empty || _txtSurname.Text != string.Empty || _cmbSex.SelectedItem != null || _cmbRank.SelectedItem != null || _cmbHospital.SelectedItem != null || _txtPassword.Text != string.Empty || _txtCallSign.Text != string.Empty)
            {
                int value;
                if (int.TryParse(_txtPhoneNumber.Text, out value))
                {
                    DoctorModel model = new DoctorModel()
                    {
                        Name = _txtName.Text,
                        Surname = _txtSurname.Text,
                        Sex = _cmbSex.SelectedItem.ToString(),
                        Rank = _cmbRank.SelectedItem.ToString(),
                        Phone_Number = int.Parse(_txtPhoneNumber.Text),
                        Hospital_Id = _hospital.Hospital_Id,
                        Password = _txtPassword.Text,
                        Call_Sign = _txtCallSign.Text,
                        Birthday = _pckDate.Value,
                        Reputation = 0,
                    };
                    _service.InsertDoctor(model);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please fill in the phone number.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _cmbHospital_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = _cmbHospital.SelectedItem.ToString();
            _hospital = _hospitals.FirstOrDefault(x => x.Name == name);
        }
    }
}
