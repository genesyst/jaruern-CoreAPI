using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysNotifyTime2
{
    public Guid Id { get; set; }

    public int Notifyhour { get; set; }

    public bool Active { get; set; }

    public Guid Teamid { get; set; }

    public string Ttype { get; set; } = null!;

    public string? Tag { get; set; }

    public DateTime? Lastaction { get; set; }
}
