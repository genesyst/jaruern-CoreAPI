using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JqzAnsuser
{
    public Guid Id { get; set; }

    public string Utype { get; set; } = null!;

    public Guid? Empid { get; set; }

    public string? Idcard { get; set; }

    public string? Sex { get; set; }

    public string? Protype { get; set; }

    public string? Fullname { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? Tname { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }
}
