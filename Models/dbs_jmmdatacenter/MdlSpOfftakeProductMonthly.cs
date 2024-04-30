using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeProductMonthly
{
    public Guid Id { get; set; }

    public Guid? Productid { get; set; }

    public string? Productcode { get; set; }

    public string? Productname { get; set; }

    public Guid? Brandid { get; set; }

    public string? Brandcode { get; set; }

    public string? Brandname { get; set; }

    public decimal? Price { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }

    public Guid? Areaid { get; set; }
}
