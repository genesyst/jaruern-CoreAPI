using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Productpricetype
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? Seq { get; set; }

    public bool Active { get; set; }

    public string? Teamid { get; set; }
}
