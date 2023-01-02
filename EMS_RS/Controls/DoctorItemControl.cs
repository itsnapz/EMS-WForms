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
    public partial class DoctorItemControl : UserControl
    {
        public DoctorModel _doctor { get; set; }
        public DoctorItemControl(DoctorModel doctor)
        {
            _doctor = doctor;
            InitializeComponent();
        }

        private void DoctorItemControl_Load(object sender, EventArgs e)
        {
            _lblDoctorId.Text = _doctor.Doctor_Id.ToString();
            _lblDoctorNameSurname.Text = _doctor.Name.ToString() + " " + _doctor.Surname.ToString();
            _lblDoctorBirthday.Text = _doctor.Birthday.ToShortDateString();
            _lblDoctorRank.Text = _doctor.Rank.ToString();
            _lblDoctorCallSign.Text = _doctor.Call_Sign.ToString();
            _lblDoctorPhoneNumber.Text = _doctor.Phone_Number.ToString();
            _lblDoctorReputation.Text = _doctor.Reputation.ToString();

            if (_doctor.Doctor_Id%2 == 0)
            {
                BackColor = Color.LightGray;
            }
            if (_doctor.Reputation>=10)
            {
                _lblDoctorReputation.Location = new Point(_lblDoctorReputation.Location.X - 3, _lblDoctorReputation.Location.Y);
            }
        }
    }
}
