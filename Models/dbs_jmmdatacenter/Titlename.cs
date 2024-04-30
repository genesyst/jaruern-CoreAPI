using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Titlename
{
    public int Id { get; set; }

    public int? Seq { get; set; }

    public string Eng { get; set; } = null!;

    public string Tha { get; set; } = null!;

    public string? Chi { get; set; }

    public string? Jap { get; set; }

    public string Stt { get; set; } = null!;
}
