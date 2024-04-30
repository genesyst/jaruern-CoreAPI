using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Storegroup
{
    public Guid Id { get; set; }

    public string Storegroupcode { get; set; } = null!;

    public string Storegroupname { get; set; } = null!;

    public Guid? Storetypeid { get; set; }

    public string? Desp { get; set; }

    public string? Teamid { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
