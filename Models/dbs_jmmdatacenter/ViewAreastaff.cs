using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAreastaff
{
    public Guid Id { get; set; }

    public Guid Areaid { get; set; }

    public Guid Staffid { get; set; }

    public string? Teamid { get; set; }

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string? Empcode { get; set; }

    public string? Titlename { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public Guid? Deptid { get; set; }
}
