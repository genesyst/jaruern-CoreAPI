using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SalaryslipDdatum
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public Guid Empid { get; set; }

    public Guid DtlId { get; set; }

    public string Type { get; set; } = null!;

    public decimal? Value { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
