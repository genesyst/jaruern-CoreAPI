using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeProductSkumonthly
{
    public Guid Id { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Skuid { get; set; }

    public string? Skucode { get; set; }

    public string? Skuname { get; set; }

    public Guid? Areaid { get; set; }

    public decimal? Price { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }
}
