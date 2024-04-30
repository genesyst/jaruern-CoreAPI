using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Department
{
    public Guid Id { get; set; }

    public string Deptcode { get; set; } = null!;

    public string Deptname { get; set; } = null!;

    public string? Teamid { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
