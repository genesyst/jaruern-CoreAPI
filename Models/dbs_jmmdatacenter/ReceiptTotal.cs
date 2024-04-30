using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ReceiptTotal
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Storeid { get; set; }

    public int? Total { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime CreateDate { get; set; }
}
