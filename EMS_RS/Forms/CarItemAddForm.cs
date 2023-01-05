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
    public partial class CarItemAddForm : Form
    {
        private DatabaseService _service;
        private CarModel _car { get; set; }
        public CarItemAddForm(DatabaseService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void CarItemAddForm_Load(object sender, EventArgs e)
        {

        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_txtCarName.Text != string.Empty && _txtCarPlate.Text != string.Empty)
            {
                CarModel model = new()
                {
                    Name = _txtCarName.Text,
                    Plate = _txtCarPlate.Text,
                };
                _service.InsertCar(model);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in all text boxes.");
            }
        }
    }
}
