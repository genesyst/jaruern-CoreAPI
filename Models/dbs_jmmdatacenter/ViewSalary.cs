using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSalary
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string HeaderData { get; set; } = null!;

    public string SubheaderData { get; set; } = null!;

    public string? YearlyData { get; set; }

    public string? MonthlyData { get; set; }

    public string? RoundData { get; set; }

    public string? PaydateData { get; set; }

    public string? FullnameData { get; set; }

    public string? DepartmentData { get; set; }

    public string? ContacttypeData { get; set; }

    public string? IncomeNetData { get; set; }

    public string? IncomeCollectData { get; set; }

    public string? TaxCollectData { get; set; }

    public string? ExpenNetData { get; set; }

    public string? SsCollectData { get; set; }

    public string? ResfunCollectData { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid DtlId { get; set; }

    public string DtlCap { get; set; } = null!;

    public string DtlType { get; set; } = null!;

    public decimal? Value { get; set; }
}
