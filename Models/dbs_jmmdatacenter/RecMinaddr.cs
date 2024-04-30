using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMinaddr
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public string? Addr { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Zipcode { get; set; }

    public int Addrtype { get; set; }
}
