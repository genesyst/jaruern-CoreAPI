using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewReceiptprod
{
    public Guid Id { get; set; }

    public string Runno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public Guid ProductskuId { get; set; }

    public decimal? Price { get; set; }

    public int? Amtout { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Allrealprice { get; set; }

    public decimal? Alldiscount { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skudisplay { get; set; }
}
