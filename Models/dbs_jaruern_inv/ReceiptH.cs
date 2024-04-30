using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class ReceiptH
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public string Receiptno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Fullprice { get; set; }

    public decimal? Deposit { get; set; }

    public string? Remark { get; set; }

    public decimal? Vatrate { get; set; }

    public decimal? Taxrate { get; set; }

    public string? Tag { get; set; }

    public string? Memberid { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid CreateBy { get; set; }

    public Guid? ReReceiptid { get; set; }

    public decimal? ReRefund { get; set; }

    public string? ReReftype { get; set; }

    public Guid? RefId { get; set; }
}
