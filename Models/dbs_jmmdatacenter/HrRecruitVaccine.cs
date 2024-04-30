using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruitVaccine
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int VacIndex { get; set; }

    public DateTime VacDate { get; set; }

    public Guid VacId { get; set; }
}
