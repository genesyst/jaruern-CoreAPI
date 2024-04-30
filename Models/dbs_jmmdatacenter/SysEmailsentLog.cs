using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysEmailsentLog
{
    public int Id { get; set; }

    public string EmailForm { get; set; } = null!;

    public string EmailTo { get; set; } = null!;

    public string Subj { get; set; } = null!;

    public string? Body { get; set; }

    public DateTime? SendDate { get; set; }

    public string? ErrorMsg { get; set; }

    public Guid? Refid { get; set; }
}
