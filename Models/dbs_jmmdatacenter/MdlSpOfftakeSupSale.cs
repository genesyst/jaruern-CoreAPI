using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeSupSale
{
    public Guid Id { get; set; }

    public Guid? Areaid { get; set; }

    public string? Storegroupname { get; set; }

    public string? Supcode { get; set; }

    public string? Supname { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }
}
