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
    public partial class CarItemEditForm : Form
    {
        private CarModel _car { get; set; }
        private DatabaseService _service;
        public CarItemEditForm(CarModel car, DatabaseService service)
        {
            InitializeComponent();
            _car = car;
            _service = service;
        }

        private void CarItemEditForm_Load(object sender, EventArgs e)
        {
            _txtCarName.Text = _car.Name;
            _txtCarPlate.Text = _car.Plate;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            CarModel model = new CarModel()
            {
                Name = _txtCarName.Text,
                Plate = _txtCarPlate.Text,
            };
            _service.UpdateCar(model, _car.Car_Id);
            Close();
        }
    }
}
