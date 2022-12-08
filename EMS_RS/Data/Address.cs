using System;
using System.Collections.Generic;

namespace EMS_RS.Data;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }
}
