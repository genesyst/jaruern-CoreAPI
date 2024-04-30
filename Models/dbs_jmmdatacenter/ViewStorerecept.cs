using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStorerecept
{
    public Guid Id { get; set; }

    public string Runno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public decimal? Pay { get; set; }

    public decimal? Realprice { get; set; }

    public Guid? Teamid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public Guid CreateBy { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateTime? CreateDate { get; set; }
}
