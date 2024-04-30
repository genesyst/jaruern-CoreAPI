using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit9Ref
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int Refindex { get; set; }

    public string Fullname { get; set; } = null!;

    public string Relation { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string Addr { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
