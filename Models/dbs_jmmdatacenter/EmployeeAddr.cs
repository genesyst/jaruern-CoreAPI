using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EmployeeAddr
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string? HomeAddr { get; set; }

    public string? CurrAddr { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
