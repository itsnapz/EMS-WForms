using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_RS.Models
{
    public class DoctorModel
    {
        public int Doctor_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Rank { get; set; }
        public int Phone_Number { get; set; }
        public int Hospital_Id { get; set; }
        public string Password { get; set; }
        public string Call_Sign { get; set; }
        public DateTime Birthday { get; set; }
        public int Reputation { get; set; }
        public HospitalModel? Hospital { get; set; }
    }
}
