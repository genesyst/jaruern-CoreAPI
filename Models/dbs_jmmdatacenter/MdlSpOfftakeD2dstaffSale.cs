using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeD2dstaffSale
{
    public Guid Id { get; set; }

    public Guid? Staffid { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public string? Storecode { get; set; }

    public string? Storename { get; set; }

    public Guid? Areaid { get; set; }

    public decimal? Price { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }
}
