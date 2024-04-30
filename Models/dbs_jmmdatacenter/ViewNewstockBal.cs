using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewNewstockBal
{
    public Guid? Id { get; set; }

    public Guid ProductskuId { get; set; }

    public Guid Storeid { get; set; }

    public int? Ain { get; set; }

    public int? Aout { get; set; }

    public decimal Prall { get; set; }

    public string Stktype { get; set; } = null!;

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public string? Skudisplay { get; set; }

    public string? Unitcode { get; set; }

    public string? Unitname { get; set; }

    public Guid Unitid { get; set; }
}
