using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysWinappregister
{
    public Guid Id { get; set; }

    public string Syscode { get; set; } = null!;

    public Guid Userid { get; set; }

    public string? SerialMboard { get; set; }

    public string? SerialDisk { get; set; }

    public string? MacAddr { get; set; }

    public int UseCount { get; set; }

    public DateTime? Lastuse { get; set; }

    public bool Activate { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
