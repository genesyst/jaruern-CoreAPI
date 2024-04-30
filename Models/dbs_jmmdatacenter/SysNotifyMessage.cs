using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysNotifyMessage
{
    public Guid Id { get; set; }

    public string Notitype { get; set; } = null!;

    public Guid? Teamid { get; set; }

    public string? Message { get; set; }

    public bool Sent { get; set; }

    public DateTime? Lastsent { get; set; }
}
