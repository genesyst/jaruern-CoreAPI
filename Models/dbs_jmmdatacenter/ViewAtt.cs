using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAtt
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public Guid? Storeid { get; set; }

    public DateTime Stamp { get; set; }

    public string Stamptype { get; set; } = null!;

    public string? Leavetype { get; set; }

    public string? Reason { get; set; }

    public string? Checkinname { get; set; }

    public string? CheckinGps { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Teamid { get; set; }
}
