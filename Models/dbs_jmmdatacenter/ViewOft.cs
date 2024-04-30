using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOft
{
    public Guid? Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid ProductskuId { get; set; }

    public decimal? Price { get; set; }

    public int? Amtout { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Allrealprice { get; set; }

    public decimal? Alldiscount { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Teamid { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Remark { get; set; }

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public Guid? BrandId { get; set; }
}
