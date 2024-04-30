using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStaffSup
{
    public Guid? Id { get; set; }

    public Guid Staffid { get; set; }

    public Guid? Storeid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public Guid? Areaid { get; set; }

    public string? Areacode { get; set; }

    public string? Areaname { get; set; }

    public string? Teamid { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string? Supcode { get; set; }

    public Guid Supid { get; set; }

    public string? Supname { get; set; }
}
