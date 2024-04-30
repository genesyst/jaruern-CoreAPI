using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Stockin
{
    public Guid Id { get; set; }

    public string Stkcard { get; set; } = null!;

    public Guid ProductskuId { get; set; }

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public int Amtin { get; set; }

    public Guid Unitid { get; set; }

    public Guid? PriceId { get; set; }

    public string Stktype { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? Pricerate { get; set; }

    public decimal? Priceall { get; set; }

    public string? Invno { get; set; }
}
