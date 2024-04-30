using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewJqzquest
{
    public Guid Id { get; set; }

    public Guid Zid { get; set; }

    public int Seq { get; set; }

    public string Quest { get; set; } = null!;

    public int? Priority { get; set; }

    public int Atype { get; set; }

    public Guid? Aid { get; set; }

    public int? Aseq { get; set; }

    public string? Anstext { get; set; }

    public int? Weight { get; set; }
}
