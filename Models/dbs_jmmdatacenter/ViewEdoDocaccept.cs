using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewEdoDocaccept
{
    public Guid Id { get; set; }

    public string Dcode { get; set; } = null!;

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Docstt { get; set; }

    public string? Idcard { get; set; }

    public string Storename { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string? Teamid { get; set; }

    public DateTime CreateDate { get; set; }
}
