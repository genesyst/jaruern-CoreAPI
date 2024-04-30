using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruitVaccinestt
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public string VacStt { get; set; } = null!;

    public string? VacRemark { get; set; }
}
