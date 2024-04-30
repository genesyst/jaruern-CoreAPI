using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysPermission
{
    public Guid Id { get; set; }

    public string Systemcode { get; set; } = null!;

    public Guid Empid { get; set; }

    public string? Func { get; set; }

    public string Stt { get; set; } = null!;
}
