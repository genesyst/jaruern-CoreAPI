using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewPermission
{
    public Guid Id { get; set; }

    public string Systemcode { get; set; } = null!;

    public Guid Empid { get; set; }

    public string? Func { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Teamid { get; set; }

    public int? Level { get; set; }
}
