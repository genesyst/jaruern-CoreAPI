using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class IntDocform
{
    public Guid Id { get; set; }

    public string Dcode { get; set; } = null!;

    public string Dname { get; set; } = null!;

    public string? Ddesp { get; set; }

    public Guid? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime CreateDate { get; set; }
}
