using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStockcard
{
    public int? StockcardLast { get; set; }

    public int? StockcardNew { get; set; }

    public Guid Storeid { get; set; }

    public string? Frtcode { get; set; }
}
