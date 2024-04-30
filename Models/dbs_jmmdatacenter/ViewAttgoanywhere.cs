using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttgoanywhere
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public Guid Eventtypeid { get; set; }

    public string Eventypename { get; set; } = null!;

    public string? Eventname { get; set; }

    public string Gps { get; set; } = null!;

    public Guid? Storeid { get; set; }

    public string? StoreOrPlace { get; set; }

    public DateTime Attime { get; set; }

    public string? Remark { get; set; }

    public string? Tag { get; set; }

    public string? Teamid { get; set; }

    public string? Address { get; set; }
}
