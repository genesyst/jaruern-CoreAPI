using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EdoTopic
{
    public Guid Id { get; set; }

    public string Edoccode { get; set; } = null!;

    public string Edocname { get; set; } = null!;

    public string? Edocdesp { get; set; }

    public Guid? Empid { get; set; }

    public Guid? Teamid { get; set; }

    public Guid? Deptid { get; set; }

    public Guid? Positionid { get; set; }

    public string Actiontype { get; set; } = null!;

    public string? Qst { get; set; }

    public string? Aws { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime ActiveDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
