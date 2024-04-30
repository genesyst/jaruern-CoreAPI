using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Newsfeed
{
    public Guid Id { get; set; }

    public int? Priority { get; set; }

    public string Subject { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public string? RedirectUrl { get; set; }

    public string? Tag { get; set; }

    public string? Showing { get; set; }

    public int? Reading { get; set; }

    public Guid? Teamid { get; set; }

    public bool Active { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
