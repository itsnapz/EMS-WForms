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
    public partial class RespondItemControl : UserControl
    {
        public RespondModel _respond { get; set; }
        public delegate void ItemClick(RespondModel respond, RespondItemControl sender);
        public event ItemClick OnItemClick;
        public RespondItemControl(RespondModel respond)
        {
            _respond = respond;
            InitializeComponent();
        }

        private void RespondItemControl_Load(object sender, EventArgs e)
        {
            _lblRespondId.Text = _respond.Respond_Id.ToString();
            _lblNameSurname.Text = _respond.Patient.Name.ToString() + " " + _respond.Patient.Surname.ToString();
            _lblPrice.Text = _respond.Price.ToString();
            _lblDate.Text = _respond.Date.ToShortDateString();
            _lblCarName.Text = _respond.Car.Name.ToString();
            _lblPatientBirth.Text = _respond.Patient.Birthday.ToShortDateString();
            _lblPatientPhoneNumber.Text = _respond.Patient.Phone_Number.ToString();

            if (_respond.Respond_Id%2==0)
            {
                BackColor = Color.LightGray;
            }
            if (_respond.Price>=10000)
            {
                _lblPrice.Location = new Point(_lblPrice.Location.X - 3, _lblPrice.Location.Y);
            }
        }

        private void RespondItemControl_Click(object sender, EventArgs e)
        {
            OnItemClick.Invoke(_respond, this);
        }
    }
}
