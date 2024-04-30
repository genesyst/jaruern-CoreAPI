using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSaleout
{
    public Guid Id { get; set; }

    public Guid? Hid { get; set; }

    public Guid ProductskuId { get; set; }

    public int? Amtout { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Storeid { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Allrealprice { get; set; }

    public decimal? Alldiscount { get; set; }

    public decimal? Price { get; set; }
}
