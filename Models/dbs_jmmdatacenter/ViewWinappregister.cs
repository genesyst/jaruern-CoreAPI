using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewWinappregister
{
    public Guid? Id { get; set; }

    public string Syscode { get; set; } = null!;

    public Guid Userid { get; set; }

    public string? SerialMboard { get; set; }

    public string? SerialDisk { get; set; }

    public string? MacAddr { get; set; }

    public int UseCount { get; set; }

    public DateTime? Lastuse { get; set; }

    public bool Activate { get; set; }

    public string Stt { get; set; } = null!;

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Teamid { get; set; }

    public string? Teamname { get; set; }
}
