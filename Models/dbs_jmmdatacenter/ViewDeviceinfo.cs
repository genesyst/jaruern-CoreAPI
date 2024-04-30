using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewDeviceinfo
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? Teamid { get; set; }

    public DateTime CreateDate { get; set; }
}
