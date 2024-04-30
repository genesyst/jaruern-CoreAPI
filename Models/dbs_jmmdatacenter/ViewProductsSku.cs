using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewProductsSku
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public string? ProductDetail { get; set; }

    public string Stt { get; set; } = null!;

    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;

    public Guid? Teamid { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? Priceid { get; set; }

    public decimal Price { get; set; }

    public string? Skudisplay { get; set; }
}
