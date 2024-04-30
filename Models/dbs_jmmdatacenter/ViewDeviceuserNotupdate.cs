using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewDeviceuserNotupdate
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Appid { get; set; }

    public string? AppVersion { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? Platform { get; set; }

    public string? PlatformVertion { get; set; }

    public DateTime? Lastsign { get; set; }
}
