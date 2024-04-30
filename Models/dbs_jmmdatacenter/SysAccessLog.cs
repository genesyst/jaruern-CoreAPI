using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysAccessLog
{
    public Guid Id { get; set; }

    public Guid? Empid { get; set; }

    public string? Systemcode { get; set; }

    public string? Url { get; set; }

    public string? Action { get; set; }

    public string? Ip { get; set; }

    public string? Value { get; set; }

    public DateTime CreateDate { get; set; }
}
