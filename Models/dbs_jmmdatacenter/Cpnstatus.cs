using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Cpnstatus
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Display { get; set; } = null!;

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;
}
