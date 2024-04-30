using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStorestaff
{
    public Guid? Id { get; set; }

    public Guid Staffid { get; set; }

    public Guid? Storeid { get; set; }

    public string Stt { get; set; } = null!;

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Branchcode { get; set; }

    public string? Branchname { get; set; }

    public int? Priority { get; set; }

    public Guid? Storegroupid { get; set; }

    public Guid? Storetypeid { get; set; }

    public string? Desp { get; set; }

    public Guid? Areaid { get; set; }

    public string? Areacode { get; set; }

    public string? Areaname { get; set; }

    public int? Seq { get; set; }

    public string? Teamid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }
}
