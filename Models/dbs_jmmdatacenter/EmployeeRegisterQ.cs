using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EmployeeRegisterQ
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;

    public string Stt { get; set; } = null!;
}
