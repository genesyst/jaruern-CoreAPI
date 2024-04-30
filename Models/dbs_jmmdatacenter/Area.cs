using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Area
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string? Desp { get; set; }

    public string? Teamid { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
