using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysNotify
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string Message { get; set; } = null!;

    public string? UrlLink { get; set; }

    public string? UrlImg { get; set; }

    public int Sent { get; set; }

    public DateTime? Sentdate { get; set; }

    public string Notifytype { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
