using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewJqzansuser
{
    public Guid Id { get; set; }

    public string Utype { get; set; } = null!;

    public Guid? Empid { get; set; }

    public string? Idcard { get; set; }

    public string? Fullname { get; set; }

    public string? Sex { get; set; }

    public string? Protype { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
