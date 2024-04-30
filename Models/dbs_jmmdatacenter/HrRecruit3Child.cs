using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit3Child
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int ChildNo { get; set; }

    public string Fullname { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public int? Birthyear { get; set; }

    public string? Position { get; set; }

    public string? EduLevel { get; set; }

    public string? Addr { get; set; }

    public string? EduOrOffice { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
