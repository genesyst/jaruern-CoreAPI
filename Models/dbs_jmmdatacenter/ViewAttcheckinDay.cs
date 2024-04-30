using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttcheckinDay
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string? Wday { get; set; }

    public int? Wdayindex { get; set; }

    public DateTime? Stampdate { get; set; }
}
