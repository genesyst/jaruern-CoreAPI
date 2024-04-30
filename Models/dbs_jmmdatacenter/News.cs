using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class News
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Imgurl { get; set; }

    public string? Title { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Newsdate { get; set; }

    public string? Linkurl { get; set; }

    public string Detail { get; set; } = null!;
}
