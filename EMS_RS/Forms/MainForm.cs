using Azure;
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

namespace EMS_RS.Forms
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService _service;
        public DoctorModel _doctor { get; set; }
        private List<RespondModel> _responds;
        private List<PatientModel> _patients;
        private List<DoctorModel> _doctors;
        private static int totalPrice;
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
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = false;
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
        }

        private void UpdateResponds()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var respond in _responds)
            {
                RespondItemControl control = new(respond);
                control.Location = new Point(0, (control.Height * index) + 10);
                control.OnItemClick += Control_OnItemClick;
                control.OnDeleteClick += Control_OnDeleteClick;
                _pnlResponds.Controls.Add(control);
                index++;
            }
        }

        private void Control_OnDeleteClick(RespondModel respond, RespondItemControl sender)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to delete this role?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                _service.DeleteRespond(respond, respond.Respond_Id);
            }
            else
            {

            }
        }

        private void _btnAddRespond_Click(object sender, EventArgs e)
        {
            RespondItemAddForm AddForm = new(_service, _doctor);
            AddForm.Show();
        }

        private void _btnResponds_Click(object sender, EventArgs e)
        {
            _pnlResponds.Visible = true;
            HideSettings();
            HidePatientLabels();
            HideDoctorLabels();
            ShowRespondLabels();
            _btnAddRespond.Visible = true;
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = false;
            UpdateResponds();
            LoadFromSql();
        }

        public void Control_OnItemClick(RespondModel respond, RespondItemControl sender)
        {
            RespondItemEditForm editForm = new RespondItemEditForm(_service, respond);
            editForm.Show();
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

        private void _btnPatients_Click(object sender, EventArgs e)
        {
            _pnlResponds.Visible = true;
            HideSettings();
            LoadFromSql();
            HideRespondLabels();
            HideDoctorLabels();
            ShowPatientLabels();
            _btnAddPatient.Visible = true;
            _btnAddDoctor.Visible = false;
            _btnAddRespond.Visible = false;
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var patient in _patients)
            {
                PatientItemControl control2 = new(patient);
                control2.Location = new Point(0, (control2.Height * index) + 10);
                control2.OnItemClick += Control2_OnItemClick;
                control2.OnDeleteClick += Control2_OnDeleteClick;
                _pnlResponds.Controls.Add(control2);
                index++;
            }
        }

        private void Control2_OnDeleteClick(PatientModel patient, PatientItemControl sender)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to delete this role?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                _service.DeletePatient(patient, patient.Patient_Id);
            }
            else
            {

            }
        }

        private void Control2_OnItemClick(PatientModel patient, PatientItemControl sender)
        {
            PatientItemEditForm patientEdit = new(patient, _service);
            patientEdit.Show();
        }

        private void _btnDoctors_Click(object sender, EventArgs e)
        {
            _pnlResponds.Visible = true;
            HideSettings();
            LoadFromSql();
            HideRespondLabels();
            HidePatientLabels();
            ShowDoctorLabels();
            _btnAddPatient.Visible = false;
            _btnAddDoctor.Visible = true;
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var doctor in _doctors)
            {
                DoctorItemControl control3 = new(doctor);
                control3.Location = new Point(0, (control3.Height * index) + 10);
                control3.OnItemClick += Control3_OnItemClick;
                control3.OnDeleteClick += Control3_OnDeleteClick;
                _pnlResponds.Controls.Add(control3);
                index++;
            }
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
                        _service.DeleteDoctor(doctor, doctor.Doctor_Id);
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

        private void _btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sett = new SettingsForm(_doctor, _service);
            sett.Show();
        }

        private void _btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientItemAddForm AddForm2 = new PatientItemAddForm(_service);
            AddForm2.Show();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            LoadFromSql();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadFromSql();
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
    }
}
