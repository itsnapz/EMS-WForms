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
    public partial class RespondItemAddForm : Form
    {
        private DatabaseService _service;
        public DoctorModel _doctor { get; set; }
        public RespondItemAddForm(DatabaseService service, DoctorModel doctor)
        {
            _service = service;
            _doctor = doctor;
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
