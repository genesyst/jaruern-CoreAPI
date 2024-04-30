using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysDeviceAtt
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string ClientVersion { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public int? Ram { get; set; }

    public string? Platform { get; set; }

    public string? Version { get; set; }

    public string? Sdk { get; set; }

    public DateTime UpdateDate { get; set; }
}
