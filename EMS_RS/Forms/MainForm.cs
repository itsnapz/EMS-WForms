using EMS_RS.Data;
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
        public Doctor _doctor { get; set; }
        public MainForm(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lblName.Text = _doctor.Name;
            _lblSurname.Text = _doctor.Surname;
            _lblRank.Text = _doctor.Rank;
        }
    }
}
