using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStfactive
{
    public Guid Staffid { get; set; }

    public Guid? Storeid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public Guid? Areaid { get; set; }

    public string? Areacode { get; set; }

    public string? Areaname { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public bool? Active { get; set; }

    public string? Stt { get; set; }

    public string? Teamid { get; set; }
}
