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
    public partial class SettingsForm : Form
    {
        private DoctorModel _doctor { get; set; }
        private DatabaseService _service;
        public SettingsForm(DoctorModel doctor, DatabaseService service)
        {
            InitializeComponent();
            _service = service;
            _doctor = doctor;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_txtOldPassword.Text == _doctor.Password && _txtNewPassword.Text == _txtNewPasswordConfirm.Text)
            {
                _service.UpdateDoctorPassword(_txtNewPassword.Text, _doctor.Doctor_Id);
            }
            else if (_txtOldPassword.Text != _doctor.Password)
            {
                MessageBox.Show("Wrong old password.");
            }
            else if (_txtNewPassword.Text != _txtNewPasswordConfirm.Text)
            {
                MessageBox.Show("Password is not the same.");
            }
        }
    }
}
