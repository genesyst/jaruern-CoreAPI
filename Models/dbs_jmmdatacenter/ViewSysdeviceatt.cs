using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSysdeviceatt
{
    public Guid Id { get; set; }

    public string? Teamname { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public bool EmpActive { get; set; }

    public string EmpStt { get; set; } = null!;

    public string ClientVersion { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public int? Ram { get; set; }

    public string? Platform { get; set; }

    public string? Version { get; set; }
}
