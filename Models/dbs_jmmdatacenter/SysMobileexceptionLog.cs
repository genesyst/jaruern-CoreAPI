using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysMobileexceptionLog
{
    public int Id { get; set; }

    public string? Os { get; set; }

    public string? Sys { get; set; }

    public string? Source { get; set; }

    public string? Msg { get; set; }

    public DateTime? Logtime { get; set; }
}
