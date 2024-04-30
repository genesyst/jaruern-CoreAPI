using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ReceiptH
{
    public Guid Id { get; set; }

    public string Runno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public decimal? Pay { get; set; }

    public decimal? Realprice { get; set; }

    public string? Remark { get; set; }

    public Guid? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
