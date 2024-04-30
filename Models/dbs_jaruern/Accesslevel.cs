using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern;

public partial class Accesslevel
{
    public string Accesstype { get; set; } = null!;

    public string Accessname { get; set; } = null!;

    public bool Active { get; set; }
}
