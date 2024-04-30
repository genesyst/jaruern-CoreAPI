using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit4Fam
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public string FamType { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public int? Age { get; set; }

    public string? Posi { get; set; }

    public string? Officeaddr { get; set; }

    public string? Life { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
