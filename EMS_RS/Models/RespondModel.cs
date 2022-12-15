using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_RS.Models
{
    public class RespondModel
    {
        public int Respond_Id { get; set; }
        public int Doctor_Id { get; set; }
        public DoctorModel? Doctor { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int Car_Id { get; set; }
        public int Patient_Id { get; set; }
    }
}
