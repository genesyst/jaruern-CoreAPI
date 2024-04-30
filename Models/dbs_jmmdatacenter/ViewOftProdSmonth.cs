using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftProdSmonth
{
    public Guid? Id { get; set; }

    public Guid ProductskuId { get; set; }

    public int? SAmt { get; set; }

    public decimal? SApay { get; set; }

    public decimal? SCash { get; set; }

    public decimal? SDis { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public Guid ProductId { get; set; }

    public Guid? BrandId { get; set; }

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public int? Aty { get; set; }

    public int? Atm { get; set; }
}
