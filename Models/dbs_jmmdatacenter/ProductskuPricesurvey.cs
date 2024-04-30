using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ProductskuPricesurvey
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public Guid Skuid { get; set; }

    public decimal? Pricemin { get; set; }

    public decimal? Pricemax { get; set; }

    public decimal Priceavg { get; set; }

    public Guid Pricetype { get; set; }

    public string? Remark { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
