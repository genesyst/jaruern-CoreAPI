using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class ReceiptX
{
    public Guid Id { get; set; }

    public Guid Receiptid { get; set; }

    public string Reasonno { get; set; } = null!;

    public string? Reasontxt { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
