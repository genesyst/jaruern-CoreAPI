using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Refundtype
{
    public string Code { get; set; } = null!;

    public string? Seq { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}
