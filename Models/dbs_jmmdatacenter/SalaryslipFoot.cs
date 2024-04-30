using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SalaryslipFoot
{
    public Guid Id { get; set; }

    public string? IncomeAllCap { get; set; }

    public string? IncomeNetCap { get; set; }

    public string? IncomeCollectCap { get; set; }

    public string? TaxCollectCap { get; set; }

    public string? ExpenNetCap { get; set; }

    public string? SsCollectCap { get; set; }

    public string? ResfunCollectCap { get; set; }
}
