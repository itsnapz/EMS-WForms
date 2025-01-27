﻿using Azure;
using EMS_RS.Controls;
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
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Numerics;

namespace EMS_RS.Forms
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService _service;
        public DoctorModel _doctor { get; set; }
        private List<RespondModel>? _responds;
        private List<PatientModel>? _patients;
        private List<DoctorModel>? _doctors;
        private List<CarModel>? _cars;
        public MainForm(DatabaseService service, DoctorModel doctor)
        {
            InitializeComponent();
            _service = service;
            _doctor = doctor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _pnlResponds.Visible = true;
            HidePatientLabels();
            HideDoctorLabels();
            HideCarLabels();
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = false;
            _btnAddCar.Visible = false;
            _lblName.Parent = pictureBox1;
            _lblName.Text = _doctor.Name + " " + _doctor.Surname;
            _lblRank.Text = _doctor.Rank;
            LoadFromSql();
            UpdateResponds();
        }
        private void LoadFromSql()
        {
            _responds = _service.GetResponds(_doctor.Doctor_Id).ToList();
            _patients = _service.GetPatients().ToList();
            _doctors = _service.GetDoctors().ToList();
            _cars = _service.GetCars().ToList();
        }
        private void UpdateResponds()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            for (int i = 0; i < _responds.Count; i++)
            {
                RespondItemControl control = new(_responds[i]);
                control.Location = new Point(0, (control.Height * index) + 10);
                control.OnItemClick += Control_OnItemClick;
                control.OnDeleteClick += Control_OnDeleteClick;
                index++;
                if (i % 2 == 0)
                {
                    control.BackColor = Color.LightGray;
                }
                else
                {
                    control.BackColor = Color.White;
                }
                _pnlResponds.Controls.Add(control);
            }
        }
        private void UpdateDoctors()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            for (int i = 0; i < _doctors.Count; i++)
            {
                DoctorItemControl control3 = new(_doctors[i]);
                control3.Location = new Point(0, (control3.Height * index) + 10);
                control3.OnItemClick += Control3_OnItemClick;
                control3.OnDeleteClick += Control3_OnDeleteClick;
                index++;
                if (i % 2 == 0)
                {
                    control3.BackColor = Color.LightGray;
                }
                else
                {
                    control3.BackColor = Color.White;
                }
                _pnlResponds.Controls.Add(control3);
            }
        }
        private void UpdatePatients()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            for (int i = 0; i < _patients.Count; i++)
            {
                PatientItemControl control2 = new(_patients[i], _service);
                control2.Location = new Point(0, (control2.Height * index) + 10);
                control2.OnItemClick += Control2_OnItemClick;
                control2.OnDeleteClick += Control2_OnDeleteClick;
                index++;
                if (i % 2 == 0)
                {
                    control2.BackColor = Color.LightGray;
                }
                else
                {
                    control2.BackColor = Color.White;
                }
                _pnlResponds.Controls.Add(control2);
            }
        }
        private void UpdateCars()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            for (int i = 0; i < _cars.Count; i++)
            {
                CarItemControl carControl = new(_cars[i]);
                carControl.Location = new Point(0, (carControl.Height * index) + 10);
                carControl.OnItemClick += CarControl_OnItemClick;
                carControl.OnDeleteClick += CarControl_OnDeleteClick;
                index++;
                if (i % 2 == 0)
                {
                    carControl.BackColor = Color.LightGray;
                }
                else
                {
                    carControl.BackColor = Color.White;
                }
                _pnlResponds.Controls.Add(carControl);
            }
        }
        private void _btnResponds_Click(object sender, EventArgs e)
        {
            LoadFromSql();
            HideCarLabels();
            HidePatientLabels();
            HideDoctorLabels();
            ShowRespondLabels();
            _btnAddRespond.Visible = true;
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = false;
            _btnAddCar.Visible = false;
            UpdateResponds();
        }
        private void _btnPatients_Click(object sender, EventArgs e)
        {
            LoadFromSql();
            HideRespondLabels();
            HideCarLabels();
            HideDoctorLabels();
            ShowPatientLabels();
            _btnAddPatient.Visible = true;
            _btnAddDoctor.Visible = false;
            _btnAddRespond.Visible = false;
            _btnAddCar.Visible = false;
            UpdatePatients();
        }
        private void _btnDoctors_Click(object sender, EventArgs e)
        {
            LoadFromSql();
            HideRespondLabels();
            HidePatientLabels();
            HideCarLabels();
            ShowDoctorLabels();
            _btnAddRespond.Visible = false;
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = true;
            _btnAddCar.Visible = false;
            UpdateDoctors();
        }
        private void _btnCars_Click(object sender, EventArgs e)
        {
            LoadFromSql();
            HideDoctorLabels();
            HidePatientLabels();
            ShowCarLabels();
            HideRespondLabels();
            _btnAddDoctor.Visible = false;
            _btnAddPatient.Visible = false;
            _btnAddRespond.Visible = false;
            _btnAddCar.Visible = true;
            UpdateCars();
        }
        private void _btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sett = new SettingsForm(_doctor, _service);
            sett.Show();
        }
        private void _btnAddRespond_Click(object sender, EventArgs e)
        {
            RespondItemAddForm AddForm = new(_service, _doctor);
            AddForm.Show();
        }
        private void _btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientItemAddForm AddForm2 = new PatientItemAddForm(_service);
            AddForm2.Show();
        }
        private void _btnAddDoctor_Click(object sender, EventArgs e)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                DoctorItemAddForm AddForm3 = new DoctorItemAddForm(_service);
                AddForm3.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do this.");
            }
        }
        private void _btnAddCar_Click(object sender, EventArgs e)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                CarItemAddForm carAdd = new(_service);
                carAdd.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do that.");
            }
        }
        private void HideCarLabels()
        {
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
        }
        private void ShowCarLabels()
        {
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
        }
        private void HideRespondLabels()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        private void ShowRespondLabels()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }
        private void HidePatientLabels()
        {
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
        }
        private void ShowPatientLabels()
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
        }
        private void HideDoctorLabels()
        {
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
        }
        private void ShowDoctorLabels()
        {
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
        }
        public void Control_OnItemClick(RespondModel respond, RespondItemControl sender)
        {
            RespondItemEditForm editForm = new RespondItemEditForm(_service, respond);
            editForm.Show();
        }
        private void Control2_OnDeleteClick(PatientModel patient, PatientItemControl sender)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                _service.DeletePatient(patient.Patient_Id);
                LoadFromSql();
                UpdatePatients();
            }
        }
        private void Control_OnDeleteClick(RespondModel respond, RespondItemControl sender)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                _service.DeleteRespond(respond.Respond_Id);
                LoadFromSql();
                UpdateResponds();
            }
        }

        private void Control2_OnItemClick(PatientModel patient, PatientItemControl sender)
        {
            PatientItemEditForm patientEdit = new(patient, _service);
            patientEdit.Show();
        }

        private void Control3_OnDeleteClick(DoctorModel doctor, DoctorItemControl sender)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                if (doctor.Rank == _doctor.Rank)
                {
                    MessageBox.Show("You can't delete yourself.");
                }
                else
                {
                    DialogResult myResult = MessageBox.Show("Are you sure you want to delete this role?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _service.DeleteDoctor(doctor.Doctor_Id);
                        LoadFromSql();
                        UpdateDoctors();
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do that.");
            }
        }

        private void Control3_OnItemClick(DoctorModel doctor, DoctorItemControl sender)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                DoctorItemEditForm doctorEdit = new DoctorItemEditForm(_service, doctor);
                doctorEdit.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do that.");
            }
        }
        private void CarControl_OnItemClick(CarModel car, CarItemControl sender)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                CarItemEditForm carEdit = new(car, _service);
                carEdit.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do that.");
            }
        }
        private void CarControl_OnDeleteClick(CarModel car, CarItemControl sender)
        {
            if (_doctor.Rank == "Head" || _doctor.Rank == "Dean")
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this role?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    _service.DeleteCar(car.Car_Id);
                    LoadFromSql();
                    UpdateCars();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Sorry, you don't have permissions to do that.");
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            LoadFromSql();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadFromSql();

            if (_btnAddRespond.Visible)
            {
                UpdateResponds();
            }
            else if (_btnAddDoctor.Visible)
            {
                UpdateDoctors();
            }
            else if (_btnAddPatient.Visible)
            {
                UpdatePatients();
            }
            else if (_btnAddCar.Visible)
            {
                UpdateCars();
            }
        }
    }
}
