using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysRealtimelocation
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public DateTime Atdate { get; set; }

    public string? Lat { get; set; }

    public string? Lng { get; set; }

    public string? Addr { get; set; }
}
