using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Patient
{
    public int PatientId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Sex { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public int? PhoneNumber { get; set; }

    public virtual ICollection<Respond> Responds { get; } = new List<Respond>();
}
