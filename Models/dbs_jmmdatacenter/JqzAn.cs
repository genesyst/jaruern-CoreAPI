using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JqzAn
{
    public Guid Id { get; set; }

    public Guid Qid { get; set; }

    public int Seq { get; set; }

    public string Anstext { get; set; } = null!;

    public int? Weight { get; set; }

    public string Stt { get; set; } = null!;
}
