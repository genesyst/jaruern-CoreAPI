using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStockout
{
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

    public decimal? PriceAll { get; set; }

    public string Stktype { get; set; } = null!;

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skudisplay { get; set; }

    public string? Skubarcode { get; set; }

    public string CurName { get; set; } = null!;

    public string? DesName { get; set; }

    public Guid Id { get; set; }

    public Guid? Unitid { get; set; }

    public string? Unitcode { get; set; }

    public string? Unitname { get; set; }
}
