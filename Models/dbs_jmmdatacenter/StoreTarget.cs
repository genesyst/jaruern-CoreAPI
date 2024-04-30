using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StoreTarget
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public string? Storecode { get; set; }

    public decimal? StoreTarget1 { get; set; }

    public decimal? AchPerc { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public Guid? Producttargetid { get; set; }
}
