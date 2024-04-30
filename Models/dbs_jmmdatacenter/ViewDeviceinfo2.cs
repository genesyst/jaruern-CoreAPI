using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewDeviceinfo2
{
    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? Platform { get; set; }

    public string? PlatformVertion { get; set; }

    public string? Appid { get; set; }

    public string? AppVersion { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Teamid { get; set; }

    public DateTime CreateDate { get; set; }
}
