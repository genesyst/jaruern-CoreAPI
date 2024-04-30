using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStfhilev
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public Guid? Deptid { get; set; }

    public Guid? Positionid { get; set; }

    public string? Teamid { get; set; }

    public string Deptcode { get; set; } = null!;

    public string Deptname { get; set; } = null!;

    public string? Posicode { get; set; }

    public string? Posiname { get; set; }

    public int? Level { get; set; }
}
