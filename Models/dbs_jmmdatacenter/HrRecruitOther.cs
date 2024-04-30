using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruitOther
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public string Induce { get; set; } = null!;

    public bool RecheckOrg { get; set; }

    public bool GuaranteeCash { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
