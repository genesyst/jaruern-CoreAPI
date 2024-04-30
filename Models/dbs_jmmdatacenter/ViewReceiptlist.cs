using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewReceiptlist
{
    public Guid Id { get; set; }

    public string Runno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public decimal? Pay { get; set; }

    public decimal? Realprice { get; set; }

    public int? Salecount { get; set; }
}
