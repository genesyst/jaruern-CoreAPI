using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysNotifyTime
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public Guid? Areaid { get; set; }

    public DateTime Sendtime { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? UrlLink { get; set; }

    public string? UrlImg { get; set; }

    public int Sent { get; set; }

    public DateTime? Sentdate { get; set; }

    public bool? Active { get; set; }

    public string Stt { get; set; } = null!;
}
