using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfSignLog
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Systemcode { get; set; } = null!;

    public string? Ip { get; set; }

    public DateTime CreateDate { get; set; }
}
