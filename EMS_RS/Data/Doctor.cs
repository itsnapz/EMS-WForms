using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Sex { get; set; }

    public string? Rank { get; set; }

    public int? PhoneNumber { get; set; }

    public int? HospitalId { get; set; }

    public string? Password { get; set; }

    public virtual Hospital? Hospital { get; set; }

    public virtual ICollection<Respond> Responds { get; } = new List<Respond>();
}
