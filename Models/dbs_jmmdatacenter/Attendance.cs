using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Attendance
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

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
