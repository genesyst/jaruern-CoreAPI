using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewRealtimelocation
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public DateTime Atdate { get; set; }

    public string? Lat { get; set; }

    public string? Lng { get; set; }

    public string? Addr { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }
}
