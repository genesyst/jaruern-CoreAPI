using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrPdpa
{
    public Guid Id { get; set; }

    public string Idcard { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public int Age { get; set; }

    public string? Addr { get; set; }

    public Guid? Empid { get; set; }

    public string? Empcode { get; set; }

    public DateTime? AcceptDate { get; set; }

    public string? AcceptVal { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
