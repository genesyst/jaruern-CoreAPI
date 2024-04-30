using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class StkGood
{
    public Guid Id { get; set; }

    public Guid Cardid { get; set; }

    public Guid Goodid { get; set; }

    public int? Piece { get; set; }

    public Guid? Unitid { get; set; }

    public decimal? Saleprice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Memberprice { get; set; }

    public decimal? Cost { get; set; }

    public string? Remark { get; set; }

    public string? Tag { get; set; }

    public bool? Active { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime CreateDate { get; set; }
}
