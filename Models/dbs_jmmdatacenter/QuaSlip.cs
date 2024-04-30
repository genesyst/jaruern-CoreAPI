using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class QuaSlip
{
    public int Id { get; set; }

    public Guid Teamid { get; set; }

    public int CreatedCount { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime UpdateDate { get; set; }
}
