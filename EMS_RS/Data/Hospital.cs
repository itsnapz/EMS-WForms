using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Hospital
{
    public int HospitalId { get; set; }

    public string? Name { get; set; }

    public string? Street { get; set; }

    public virtual ICollection<Doctor> Doctors { get; } = new List<Doctor>();
}
