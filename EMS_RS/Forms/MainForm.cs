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

namespace EMS_RS.Forms
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService _service;
        public DoctorModel _doctor { get; set; }
        private List<RespondModel> _responds;
        private List<PatientModel> _patients;
        private List<DoctorModel> _doctors;
        public MainForm(DatabaseService service, DoctorModel doctor)
        {
            InitializeComponent();
            _service = service;
            _doctor = doctor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HidePatientLabels();
            HideDoctorLabels();
            _btnAddPatient.Visible = false;
            _lblName.Text = _doctor.Name + " " + _doctor.Surname;
            _lblRank.Text = _doctor.Rank;
            LoadFromSql();
            UpdateResponds();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            LoadFromSql();
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
                _pnlResponds.Controls.Add(control);
                index++;
            }
        }

        private void _btnAddRespond_Click(object sender, EventArgs e)
        {
            RespondItemAddForm AddForm = new(_service, _doctor);
            AddForm.Show();
        }

        private void _btnResponds_Click(object sender, EventArgs e)
        {
            HidePatientLabels();
            HideDoctorLabels();
            ShowRespondLabels();
            _btnAddPatient.Visible = false;
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
            LoadFromSql();
            HideRespondLabels();
            HideDoctorLabels();
            ShowPatientLabels();
            _btnAddPatient.Visible = true;
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var patient in _patients)
            {
                PatientItemControl control2 = new(patient);
                control2.Location = new Point(0, (control2.Height * index) + 10);
                _pnlResponds.Controls.Add(control2);
                index++;
            }
        }

        private void _btnDoctors_Click(object sender, EventArgs e)
        {
            LoadFromSql();
            HideRespondLabels();
            HidePatientLabels();
            ShowDoctorLabels();
            _btnAddPatient.Visible = false;
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var doctor in _doctors)
            {
                DoctorItemControl control3 = new(doctor);
                control3.Location = new Point(0, (control3.Height * index) + 10);
                _pnlResponds.Controls.Add(control3);
                index++;
            }
        }

        private void _btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void _btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientItemAddForm AddForm2 = new PatientItemAddForm(_service);
            AddForm2.Show();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            LoadFromSql();
            UpdateResponds();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadFromSql();
            UpdateResponds();
        }
    }
}
