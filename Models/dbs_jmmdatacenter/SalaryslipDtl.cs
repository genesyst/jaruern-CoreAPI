using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SalaryslipDtl
{
    public string DtlCap { get; set; } = null!;

    public string DtlType { get; set; } = null!;

    public Guid? Hid { get; set; }

    public Guid? Id { get; set; }
}
