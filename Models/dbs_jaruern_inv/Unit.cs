using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Unit
{
    public Guid Id { get; set; }

    public int Seq { get; set; }

    public string Uniten { get; set; } = null!;

    public string Unitth { get; set; } = null!;

    public bool? Active { get; set; }
}
