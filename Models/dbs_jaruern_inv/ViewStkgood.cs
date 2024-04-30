using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class ViewStkgood
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public string Cardno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public int? Piece { get; set; }

    public string Unitth { get; set; } = null!;

    public string Uniten { get; set; } = null!;

    public decimal? Saleprice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Memberprice { get; set; }

    public decimal? Cost { get; set; }

    public string? Remark { get; set; }

    public string Skubarcode { get; set; } = null!;

    public string? Skuqrcode { get; set; }

    public string? Skusize { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid Goodid { get; set; }
}
