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
    public partial class PatientItemEditForm : Form
    {
        private DatabaseService _service;
        private PatientModel _patient { get; set; }
        public PatientItemEditForm(PatientModel patient, DatabaseService service)
        {
            InitializeComponent();
            _patient = patient;
            _service = service;
        }

        private void PatientItemEditForm_Load(object sender, EventArgs e)
        {
            _cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbSex.Controls.Clear();

            _txtName.Text = _patient.Name;
            _txtSurname.Text = _patient.Surname;
            _pckDate.Value = _patient.Birthday;
            _cmbSex.SelectedItem = _patient.Sex;
            _txtStreet.Text = _patient.Street;
            _txtCity.Text = _patient.City;
            _txtCountry.Text = _patient.Country;
            _txtZip.Text = _patient.Zip;
            _txtPhoneNumber.Text = _patient.Phone_Number.ToString();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            PatientModel model = new()
            {
                Name = _txtName.Text,
                Surname = _txtSurname.Text,
                Birthday = _pckDate.Value.Date,
                Sex = _cmbSex.SelectedItem.ToString(),
                Street = _txtStreet.Text,
                City = _txtCity.Text,
                Country = _txtCountry.Text,
                Zip = _txtZip.Text,
                Phone_Number = int.Parse(_txtPhoneNumber.Text),
            };
            _service.UpdatePatient(model, _patient.Patient_Id);
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
