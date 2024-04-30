using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysExceptionLog
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? Target { get; set; }

    public string? Source { get; set; }

    public string? Stacktrace { get; set; }

    public DateTime? Logtime { get; set; }
}
