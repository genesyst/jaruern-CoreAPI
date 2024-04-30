using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EmployeeSelfupdate
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string? Titlename { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Idcard { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Tel { get; set; }

    public string? HomeAddr { get; set; }

    public string? CurrAddr { get; set; }

    public DateTime? Validate { get; set; }

    public string? Remark { get; set; }

    public string Stt { get; set; } = null!;

    public Guid CreateBy { get; set; }

    public DateTime CreateDate { get; set; }
}
