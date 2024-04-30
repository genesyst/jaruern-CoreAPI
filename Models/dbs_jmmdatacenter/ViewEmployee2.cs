using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewEmployee2
{
    public Guid? Id { get; set; }

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

    public bool Active { get; set; }

    public string? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public string Deptcode { get; set; } = null!;

    public string Deptname { get; set; } = null!;

    public string? Posicode { get; set; }

    public string? Posiname { get; set; }
}
