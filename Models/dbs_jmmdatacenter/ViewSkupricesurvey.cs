using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSkupricesurvey
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public Guid Skuid { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skudisplay { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public decimal? Pricemin { get; set; }

    public decimal? Pricemax { get; set; }

    public decimal Priceavg { get; set; }

    public Guid Pricetype { get; set; }

    public string PricetypeName { get; set; } = null!;

    public string? Remark { get; set; }
}
