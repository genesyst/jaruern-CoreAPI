using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewMReceiptstoresku
{
    public DateTime Atdate { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Areacode { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public decimal? Price { get; set; }

    public int? Amtout { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Allrealprice { get; set; }

    public decimal? Alldiscount { get; set; }
}
