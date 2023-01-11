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

namespace EMS_RS.Controls
{
    public partial class PatientItemControl : UserControl
    {
        private DatabaseService _service;
        public delegate void ItemClick(PatientModel patient, PatientItemControl sender);
        public event ItemClick OnItemClick;
        public delegate void DeleteClick(PatientModel patient, PatientItemControl sender);
        public event DeleteClick OnDeleteClick;
        private PatientModel _patient { get; set; }
        private List<PatientModel> _patients;
        public PatientItemControl(PatientModel patient, DatabaseService service)
        {
            InitializeComponent();
            _patient = patient;
            _patients = new();
            _service = service;
        }

        private void PatientItemControl_Load(object sender, EventArgs e)
        {
            _patients = _service.GetPatients().ToList();

            _lblPatientId.Text = _patient.Patient_Id.ToString();
            _lblPatientNameSurname.Text = _patient.Name.ToString() + " " + _patient.Surname.ToString();
            _lblPatientBirthday.Text = _patient.Birthday.ToShortDateString();
            _lblPatientStreet.Text = _patient.Street.ToString();
            _lblPatientCity.Text = _patient.City.ToString();
            _lblPatientZIP.Text = _patient.Zip.ToString();
            _lblPatientPhoneNumber.Text = _patient.Phone_Number.ToString();
        }

        private void PatientItemControl_Click(object sender, EventArgs e)
        {
            OnItemClick.Invoke(_patient, this);
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClick.Invoke(_patient, this);
        }
    }
}
