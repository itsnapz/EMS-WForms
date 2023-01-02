using EMS_RS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_RS.Controls
{
    public partial class PatientItemControl : UserControl
    {
        public PatientModel _patient { get; set; }
        public PatientItemControl(PatientModel patient)
        {
            _patient = patient;
            InitializeComponent();
        }

        private void PatientItemControl_Load(object sender, EventArgs e)
        {
            _lblPatientId.Text = _patient.Patient_Id.ToString();
            _lblPatientNameSurname.Text = _patient.Name.ToString() + " " + _patient.Surname.ToString();
            _lblPatientBirthday.Text = _patient.Birthday.ToShortDateString();
            _lblPatientStreet.Text = _patient.Street.ToString();
            _lblPatientCity.Text = _patient.City.ToString();
            _lblPatientZIP.Text = _patient.Zip.ToString();
            _lblPatientPhoneNumber.Text = _patient.Phone_Number.ToString();

            if (_patient.Patient_Id%2==0)
            {
                BackColor = Color.LightGray;
            }
        }
    }
}
