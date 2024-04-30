using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewEmployee
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Sex { get; set; } = null!;

    public string? Idcard { get; set; }

    public DateTime? Birthdate { get; set; }

    public DateTime? Startworkdate { get; set; }

    public DateTime? Lastworkdate { get; set; }

    public string? Teamid { get; set; }

    public string? Deptcode { get; set; }

    public string? Deptname { get; set; }
}
