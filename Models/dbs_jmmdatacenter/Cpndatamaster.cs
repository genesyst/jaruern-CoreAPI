using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Cpndatamaster
{
    public Guid Id { get; set; }

    public string Valuetype { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Valueposi { get; set; }

    public Guid? Producttypeid { get; set; }

    public Guid? Teamid { get; set; }

    public Guid? Cpnid { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public Guid? Storegroupid { get; set; }

    public decimal? Value { get; set; }
}
