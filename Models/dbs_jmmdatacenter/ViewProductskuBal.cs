using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewProductskuBal
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public Guid ProductId { get; set; }

    public Guid Storeid { get; set; }

    public string Stktype { get; set; } = null!;

    public string? Skudisplay { get; set; }

    public string Unitcode { get; set; } = null!;

    public string? Unitname { get; set; }

    public int? Amtbal { get; set; }

    public string? Productcode { get; set; }

    public string? Productname { get; set; }

    public string? Brandcode { get; set; }

    public string? Brandname { get; set; }

    public decimal? Price { get; set; }
}
