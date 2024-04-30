using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysDevice
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string? Appid { get; set; }

    public string? AppVersion { get; set; }

    public string? HwSerial { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? Platform { get; set; }

    public string? PlatformVertion { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Uuid { get; set; }
}
