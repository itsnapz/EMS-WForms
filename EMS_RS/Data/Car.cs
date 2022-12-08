using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Car
{
    public int CarId { get; set; }

    public string? Name { get; set; }

    public string? Plate { get; set; }

    public virtual ICollection<Respond> Responds { get; } = new List<Respond>();
}
