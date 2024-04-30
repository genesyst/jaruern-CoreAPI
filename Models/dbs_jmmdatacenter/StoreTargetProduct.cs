using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StoreTargetProduct
{
    public Guid Id { get; set; }

    public Guid Ptargetid { get; set; }

    public string Ptargetcode { get; set; } = null!;

    public decimal? PtargetSaletarget { get; set; }

    public Guid? Productid { get; set; }

    public decimal? ProductSaletarget { get; set; }

    public Guid? Skuid { get; set; }

    public decimal? SkuSaletarget { get; set; }

    public string Type { get; set; } = null!;

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;
}
