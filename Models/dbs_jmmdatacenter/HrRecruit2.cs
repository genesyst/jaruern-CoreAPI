using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit2
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int? ChildAmt { get; set; }

    public int? BoyAmt { get; set; }

    public int? GirlAmt { get; set; }

    public int? BrethrenAmt { get; set; }

    public int? ManAmt { get; set; }

    public int? WomAmt { get; set; }

    public int? MyNo { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
