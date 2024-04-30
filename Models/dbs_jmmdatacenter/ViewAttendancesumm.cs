using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttendancesumm
{
    public Guid Id { get; set; }

    public int? Day { get; set; }

    public string? Stampdate { get; set; }

    public string? Stamptime { get; set; }

    public string Stamptype { get; set; } = null!;

    public string? Leavetype { get; set; }

    public string? Storename { get; set; }

    public string? Branchname { get; set; }

    public Guid Userid { get; set; }

    public DateTime Stamp { get; set; }

    public Guid? Storeid { get; set; }

    public string? Storecode { get; set; }
}
