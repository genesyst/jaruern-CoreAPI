using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStockbalDtl
{
    public Guid? ViewId { get; set; }

    public Guid ProductskuId { get; set; }

    public Guid Storeid { get; set; }

    public int? Amtbal { get; set; }

    public Guid Unitid { get; set; }

    public Guid? PriceId { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public string? Skudisplay { get; set; }

    public decimal? Price { get; set; }

    public string Unitcode { get; set; } = null!;

    public string? Unitname { get; set; }
}
