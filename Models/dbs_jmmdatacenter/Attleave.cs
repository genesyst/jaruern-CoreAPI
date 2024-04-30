using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Attleave
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public Guid? Storeid { get; set; }

    public DateTime Startleave { get; set; }

    public DateTime Endleave { get; set; }

    public int Leavetype { get; set; }

    public int Leavedays { get; set; }

    public int? Leavehours { get; set; }

    public string? Reason { get; set; }

    public string? Imgnames { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
