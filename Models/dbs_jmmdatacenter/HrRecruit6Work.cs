using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit6Work
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int Posiindex { get; set; }

    public string Positionname { get; set; } = null!;

    public int? Salary { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Companyname { get; set; } = null!;

    public string Companyaddr { get; set; } = null!;

    public string? Tel { get; set; }

    public string Jobdesc { get; set; } = null!;

    public string Quitreason { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
