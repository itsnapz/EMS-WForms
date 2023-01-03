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
    public partial class RespondItemEditForm : Form
    {
        private RespondModel _respond { get; set; }
        private DatabaseService _service;
        private List<CarModel> _cars;
        private List<PatientModel> _patients;
        private PatientModel _patient { get; set; }
        private CarModel _car { get; set; }


        public RespondItemEditForm(DatabaseService service, RespondModel respond)
        {
            InitializeComponent();
            _service = service;
            _respond = respond;
            _cars = new List<CarModel>();
            _patients = new List<PatientModel>();
        }

        private void RespondItemEditForm_Load(object sender, EventArgs e)
        {
            _cars = _service.GetCars().ToList();
            _patients = _service.GetPatients().ToList();

            _cmbCars.Items.Clear();
            _cmbPatients.Items.Clear();

            foreach (var car in _cars)
            {
                _cmbCars.Items.Add(car.Name);
            }
            foreach (var patient in _patients)
            {
                _cmbPatients.Items.Add(patient.Name + " " + patient.Surname);
            }
            label4.Text = _respond.Patient.Name + " " + _respond.Patient.Surname;
            label5.Text = _respond.Car.Name;
            label6.Text = _respond.Price.ToString();
            _cmbPatients.SelectedItem = _respond.Patient.Name + " " + _respond.Patient.Surname;
            _cmbCars.SelectedItem = _respond.Car.Name;
            _txtPrice.Text = _respond.Price.ToString();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            RespondModel model = new()
            {
                Price = int.Parse(_txtPrice.Text),
                Car_Id = _car.Car_Id,
                Patient_Id = _patient.Patient_Id,
            };
            _service.UpdateRespond(model, _respond.Respond_Id);
            Close();
        }

        private void _cmbPatients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_cmbPatients.SelectedItem != null)
            {
                string name = _cmbPatients.SelectedItem.ToString();
                _patient = _patients.FirstOrDefault(x => x.Name + " " + x.Surname == name);
            }
        }

        private void _cmbCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_cmbCars.SelectedItem != null)
            {
                string carName = _cmbCars.SelectedItem.ToString();
                _car = _cars.FirstOrDefault(x => x.Name == carName);
            }
        }
    }
}
