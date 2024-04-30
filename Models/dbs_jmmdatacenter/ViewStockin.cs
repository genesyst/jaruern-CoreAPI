using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStockin
{
    public Guid Id { get; set; }

    public string Stkcard { get; set; } = null!;

    public Guid ProductskuId { get; set; }

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public int Amtin { get; set; }

    public Guid Unitid { get; set; }

    public Guid? PriceId { get; set; }

    public string Stktype { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public string? Skudisplay { get; set; }

    public decimal? Price { get; set; }

    public string Unitcode { get; set; } = null!;

    public string? Unitname { get; set; }

    public decimal? Pricerate { get; set; }

    public decimal? Priceall { get; set; }

    public string? Invno { get; set; }
}
