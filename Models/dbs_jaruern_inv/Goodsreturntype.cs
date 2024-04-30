using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Goodsreturntype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}
