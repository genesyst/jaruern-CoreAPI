using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RunStockcard
{
    public Guid Id { get; set; }

    public Guid? Storeid { get; set; }

    public string Cardcode { get; set; } = null!;

    public string Stocktype { get; set; } = null!;

    public DateTime UpdateDate { get; set; }
}
