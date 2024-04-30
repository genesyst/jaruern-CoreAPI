using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit0
{
    public Guid Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Nic { get; set; } = null!;

    public string? Idcard { get; set; }

    public string Posiname { get; set; } = null!;

    public string? Provname { get; set; }

    public string Sex { get; set; } = null!;

    public int Height { get; set; }

    public int Weight { get; set; }

    public int Age { get; set; }

    public string Tel { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Skin { get; set; }

    public string? Tatoo { get; set; }

    public string Addr { get; set; } = null!;

    public string? EduLev { get; set; }

    public string? EduInst { get; set; }

    public string? Workname1 { get; set; }

    public string? Worktime1 { get; set; }

    public string? Workreason1 { get; set; }

    public string? Workname2 { get; set; }

    public string? Worktime2 { get; set; }

    public string? Workreason2 { get; set; }

    public string? Workname3 { get; set; }

    public string? Worktime3 { get; set; }

    public string? Workreason3 { get; set; }

    public string? Workname4 { get; set; }

    public string? Worktime4 { get; set; }

    public string? Workreason4 { get; set; }

    public string? Dadname { get; set; }

    public int? Dadage { get; set; }

    public string? Dadjob { get; set; }

    public string? Momname { get; set; }

    public int? Momage { get; set; }

    public string? Momjob { get; set; }

    public string? Marname { get; set; }

    public int? Marage { get; set; }

    public string? Marjob { get; set; }

    public int? Child { get; set; }

    public string Refname { get; set; } = null!;

    public string Refrelat { get; set; } = null!;

    public string Reftel { get; set; } = null!;

    public string? Refaddr { get; set; }

    public string Readytowork { get; set; } = null!;

    public Guid? ActionBy { get; set; }

    /// <summary>
    /// W=กำลังตรวจสอบ | F = ส่งต่อหน่วยงาน | D = นัดสัมภาษณ์ | C = จำหน่ายออก
    /// </summary>
    public string? ActionStatus { get; set; }

    public DateTime? Actiondate { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
