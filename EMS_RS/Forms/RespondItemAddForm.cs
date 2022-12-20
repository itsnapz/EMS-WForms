using EMS_RS.Models;
using EMS_RS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_RS.Forms
{
    public partial class RespondItemAddForm : Form
    {
        public DoctorModel _doctor { get; set; }
        public RespondModel _respond { get; set; }
        private DatabaseService _service;
        private List<PatientModel> _patients;
        private List<CarModel> _cars;
        private CarModel? _car { get; set; }
        private PatientModel? _patient { get; set; }
        public RespondItemAddForm(DatabaseService service, DoctorModel doctor)
        {
            _cars = new List<CarModel>();
            _patients = new List<PatientModel>();
            _service = service;
            _doctor = doctor;
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RespondItemAddForm_Load(object sender, EventArgs e)
        {
            _cmbCars.Items.Clear();
            _cmbPatients.Items.Clear();

            _cmbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;

            var cars = _service.GetCars();
            var patients = _service.GetPatients();

            _cars = cars.ToList();
            _patients = patients.ToList();

            foreach (var car in _cars)
            {
                _cmbCars.Items.Add(car.Name);
            }
            foreach (var patient in _patients)
            {
                _cmbPatients.Items.Add(patient.Name + " " + patient.Surname);
            }
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            RespondModel model = new RespondModel()
            {
                Doctor_Id = _doctor.Doctor_Id,
                Price = int.Parse(_txtPrice.Text),
                Car_Id = _car.Car_Id,
                Patient_Id = _patient.Patient_Id,
            };
            _service.InsertRespond(model);
            Close();
        }

        private void _cmbPatients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_cmbPatients.SelectedItem != null)
            {
                string name = _cmbPatients.SelectedItem.ToString();
                _patient = _patients.FirstOrDefault(x => x.Name + " " + x.Surname == name);
            }
            else
            {
                MessageBox.Show("Please select Patient.");
            }
        }

        private void _cmbCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_cmbCars.SelectedItem != null)
            {
                string carName = _cmbCars.SelectedItem.ToString();
                _car = _cars.FirstOrDefault(x => x.Name == carName);
            }
            else
            {
                MessageBox.Show("Please select car.");
            }
        }
    }
}
