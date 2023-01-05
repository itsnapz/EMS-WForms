using EMS_RS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_RS.Controls
{
    public partial class CarItemControl : UserControl
    {
        public delegate void ItemClick(CarModel car, CarItemControl sender);
        public event ItemClick OnItemClick;
        public delegate void DeleteClick(CarModel car, CarItemControl sender);
        public event ItemClick OnDeleteClick;
        public CarModel _car { get; set; }
        public CarItemControl(CarModel car)
        {
            InitializeComponent();
            _car = car;
        }

        private void CarItemControl_Load(object sender, EventArgs e)
        {
            _lblCarId.Text = _car.Car_Id.ToString();
            _lblCarName.Text = _car.Name.ToString();
            _lblCarPlate.Text = _car.Plate.ToString();

            if (_car.Car_Id%2==0)
            {
                BackColor = Color.LightGray;
            }
        }

        private void CarItemControl_Click(object sender, EventArgs e)
        {
            OnItemClick.Invoke(_car, this);
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClick.Invoke(_car, this);
        }
    }
}
