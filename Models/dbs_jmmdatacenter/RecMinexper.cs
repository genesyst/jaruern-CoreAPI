using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMinexper
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public int Seq { get; set; }

    public string Positionname { get; set; } = null!;

    public int? Salary { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string Company { get; set; } = null!;

    public string? CompanyAddr { get; set; }

    public string? Tel { get; set; }

    public string? Jd { get; set; }
}
