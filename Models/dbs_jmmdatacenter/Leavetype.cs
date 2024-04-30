using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Leavetype
{
    public Guid Id { get; set; }

    public int Leavetype1 { get; set; }

    public string Leavename { get; set; } = null!;

    public string? Desp { get; set; }

    public string Stt { get; set; } = null!;
}
