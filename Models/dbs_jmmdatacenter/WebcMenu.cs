using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class WebcMenu
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Menucode { get; set; } = null!;

    public string Menuname { get; set; } = null!;

    public string? Description { get; set; }

    public string? Cssclass { get; set; }

    public string? Url { get; set; }

    public string? Mvcaction { get; set; }

    public bool? Visable { get; set; }

    public bool? Enable { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? Teamid { get; set; }

    public string Syscode { get; set; } = null!;
}
