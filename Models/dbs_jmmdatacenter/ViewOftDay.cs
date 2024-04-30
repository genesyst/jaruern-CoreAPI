using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftDay
{
    public Guid? Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid ProductskuId { get; set; }

    public decimal? Unitprice { get; set; }

    public int? Saleout { get; set; }

    public decimal? Allprice { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public Guid? BrandId { get; set; }

    public Guid Areaid { get; set; }

    public Guid Storeid { get; set; }

    public string Runno { get; set; } = null!;

    public string? Brandname { get; set; }
}
