using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Arearegion
{
    public Guid Id { get; set; }

    public string Regname { get; set; } = null!;

    public Guid Teamid { get; set; }

    public string Areaids { get; set; } = null!;

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
