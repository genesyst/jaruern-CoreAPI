using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysFuncsett
{
    public Guid Id { get; set; }

    public string Func { get; set; } = null!;

    public string? Sett { get; set; }

    public bool Active { get; set; }

    public Guid? Teamid { get; set; }

    public Guid? Areaid { get; set; }
}
