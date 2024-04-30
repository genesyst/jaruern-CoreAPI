using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SalaryslipHdatum
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

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

    public string? IncomeAllData { get; set; }

    public string? IncomeNetData { get; set; }

    public string? IncomeCollectData { get; set; }

    public string? TaxCollectData { get; set; }

    public string? ExpenNetData { get; set; }

    public string? SsCollectData { get; set; }

    public string? ResfunCollectData { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? Atdate { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
