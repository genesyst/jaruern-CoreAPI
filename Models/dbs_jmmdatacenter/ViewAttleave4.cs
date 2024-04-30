using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttleave4
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public DateTime Startleave { get; set; }

    public DateTime Endleave { get; set; }

    public int Leavedays { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }
}
