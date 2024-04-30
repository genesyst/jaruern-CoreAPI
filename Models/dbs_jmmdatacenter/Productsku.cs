using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Productsku
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string? Skuqrcode { get; set; }

    public Guid ProductId { get; set; }

    public string? ProductDetail { get; set; }

    public decimal? Weight { get; set; }

    public string? Tag { get; set; }

    public bool? Discontinued { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Skudisplay { get; set; }
}
