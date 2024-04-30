using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Recript
{
    public Guid Id { get; set; }

    public Guid? Recriptid { get; set; }

    public Guid? Goodsid { get; set; }

    public int Piece { get; set; }

    public decimal? Saleprice { get; set; }

    public decimal? Cash { get; set; }

    public string Cashtype { get; set; } = null!;

    public string? Tag { get; set; }

    public string? Remark { get; set; }

    public bool? Active { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime CreateDate { get; set; }

    public string? ReCode { get; set; }

    public string? ReReason { get; set; }
}
