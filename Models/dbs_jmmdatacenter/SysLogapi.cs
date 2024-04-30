using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysLogapi
{
    public int Id { get; set; }

    public string Actionname { get; set; } = null!;

    public DateTime Logtime { get; set; }

    public string? Logowner { get; set; }

    public string? Message { get; set; }

    public string? Tag { get; set; }
}
