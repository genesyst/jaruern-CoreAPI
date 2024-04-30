using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Stockout
{
    public Guid Id { get; set; }

    public string Stkocard { get; set; } = null!;

    public Guid ProductskuId { get; set; }

    public Guid? CurrStoreid { get; set; }

    public Guid? DestStoreid { get; set; }

    public string? DestStorename { get; set; }

    public string? DestStoreaddr { get; set; }

    public DateTime Atdate { get; set; }

    public int Amtout { get; set; }

    public Guid? PriceId { get; set; }

    public string? Remark { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? PriceAll { get; set; }

    public string Stktype { get; set; } = null!;

    public Guid? Unitid { get; set; }
}
