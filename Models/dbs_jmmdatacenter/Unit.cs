using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Unit
{
    public Guid Id { get; set; }

    public string Unitcode { get; set; } = null!;

    public string? Unitname { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Capacity { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
