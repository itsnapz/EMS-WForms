using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Respond
{
    public int RespondId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? Date { get; set; }

    public int? Price { get; set; }

    public int? CarId { get; set; }

    public int? PatientId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }
}
