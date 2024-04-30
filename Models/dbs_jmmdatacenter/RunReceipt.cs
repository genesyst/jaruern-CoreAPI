using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RunReceipt
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public string ReceiptCode { get; set; } = null!;

    public DateTime UpdateDate { get; set; }
}
