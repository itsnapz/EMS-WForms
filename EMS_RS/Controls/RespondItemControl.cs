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
        public RespondItemControl(RespondModel respond)
        {
            _respond = respond;
            InitializeComponent();
        }

        private void RespondItemControl_Load(object sender, EventArgs e)
        {
            _lblRespondId.Text = _respond.Respond_Id.ToString();
            //_lblNameSurname.Text = 
            _lblPrice.Text = _respond.Price.ToString();
            _lblDate.Text = _respond.Date.ToShortDateString();
            _lblCarName.Text = _respond.Car.Name.ToString();
        }
    }
}
