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
    public partial class PatientItemAddForm : Form
    {
        private DatabaseService _service;
        public PatientItemAddForm(DatabaseService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void PatientItemAddForm_Load(object sender, EventArgs e)
        {
            _cmbPatientSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_txtPatientName.Text != string.Empty || _txtPatientSurname.Text != string.Empty || _txtPatientStreet.Text != string.Empty || _txtPatientCity.Text != string.Empty || _txtPatientCountry.Text != string.Empty || _txtPatientZip.Text != string.Empty || _cmbPatientSex.SelectedItem != null)
            {
                int value;
                if (int.TryParse(_txtPatientPhoneNumber.Text, out value))
                {
                    PatientModel model = new PatientModel()
                    {
                        Name = _txtPatientName.Text,
                        Surname = _txtPatientSurname.Text,
                        Birthday = _pckBirthday.Value,
                        Sex = _cmbPatientSex.SelectedItem.ToString(),
                        Street = _txtPatientStreet.Text,
                        City = _txtPatientCity.Text,
                        Country = _txtPatientCountry.Text,
                        Zip = _txtPatientZip.Text,
                        Phone_Number = int.Parse(_txtPatientPhoneNumber.Text),
                    };
                    _service.InsertPatient(model);
                    Close();
                }
                else
                {
                    MessageBox.Show("Phone number must be number.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all boxes.");
            }
        }
    }
}
