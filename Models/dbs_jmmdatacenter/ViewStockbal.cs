using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStockbal
{
    public Guid ProductskuId { get; set; }

    public string? Skudisplay { get; set; }

    public int? Amtbal { get; set; }

    public Guid Storeid { get; set; }

    public string Skucode { get; set; } = null!;
}
