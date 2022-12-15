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
        public MainForm(DatabaseService service, DoctorModel doctor)
        {
            InitializeComponent();
            _service = service;
            _doctor = doctor;
            _responds = new List<RespondModel>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lblName.Text = _doctor.Name + " " + _doctor.Surname;
            _lblRank.Text = _doctor.Rank;
            _responds = _service.GetResponds(_doctor.Doctor_Id).ToList();
            UpdateUi();
        }

        private void UpdateUi()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var respond in _responds)
            {
                RespondItemControl control = new(respond);
                control.Location = new Point(0, (control.Height * index) + 10);
                _pnlResponds.Controls.Add(control);
                index++;
            }
        }
    }
}
