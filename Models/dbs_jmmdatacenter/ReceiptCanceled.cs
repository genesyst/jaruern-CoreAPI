using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ReceiptCanceled
{
    public Guid Id { get; set; }

    public Guid? Storeid { get; set; }

    public Guid Receiptid { get; set; }

    public string ReceiptRunno { get; set; } = null!;

    public Guid? ReceiptidCan { get; set; }

    public string? ReceiptRunnoCan { get; set; }

    public int CancelType { get; set; }

    public string? CancelRemark { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
