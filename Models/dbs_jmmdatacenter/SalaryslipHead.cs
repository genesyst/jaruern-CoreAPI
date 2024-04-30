using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SalaryslipHead
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public string Slipname { get; set; } = null!;

    public string HeaderCap { get; set; } = null!;

    public string? SubheaderCap { get; set; }

    public string? YearlyCap { get; set; }

    public string? MonthlyCap { get; set; }

    public string? RoundCap { get; set; }

    public string? PaydateCap { get; set; }

    public string? FullnameCap { get; set; }

    public string? DepartmentCap { get; set; }

    public string? ContacttypeCap { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
