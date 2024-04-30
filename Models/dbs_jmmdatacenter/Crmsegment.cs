using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Crmsegment
{
    public Guid Id { get; set; }

    public string Segcode { get; set; } = null!;

    public string Segname { get; set; } = null!;

    public Guid? Team { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
