using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Employee
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

    public string? Tel { get; set; }

    public Guid? Deptid { get; set; }

    public Guid? Positionid { get; set; }

    public bool Active { get; set; }

    public string? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
