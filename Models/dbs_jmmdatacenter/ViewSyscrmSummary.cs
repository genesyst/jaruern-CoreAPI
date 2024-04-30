using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSyscrmSummary
{
    public Guid? Teamid { get; set; }

    public DateTime? CreateDay { get; set; }

    public string? DayDisplay { get; set; }

    public TimeSpan? Firsttime { get; set; }

    public TimeSpan? Lasttime { get; set; }

    public int? RegisterCount { get; set; }

    public int? TelCount { get; set; }

    public int? EmailCount { get; set; }

    public int? ErrorLog { get; set; }
}
