using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Attgoanywhere
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public Guid Eventtypeid { get; set; }

    public string? Eventname { get; set; }

    public string Gps { get; set; } = null!;

    public string? Address { get; set; }

    public Guid? Storeid { get; set; }

    public string? Atplace { get; set; }

    public DateTime Attime { get; set; }

    public string? Remark { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
