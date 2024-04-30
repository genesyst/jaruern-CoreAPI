using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftSkuD2d
{
    public Guid? Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid ProductskuId { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public decimal? SPriceunit { get; set; }

    public int? SPie { get; set; }

    public decimal? SPrice { get; set; }

    public decimal? SCash { get; set; }

    public decimal? SDis { get; set; }

    public Guid Storeid { get; set; }
}
