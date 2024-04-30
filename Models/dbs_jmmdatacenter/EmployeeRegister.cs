using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EmployeeRegister
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string EmailAddr { get; set; } = null!;

    public bool? Activate { get; set; }

    public int? Vqs1 { get; set; }

    public string? Vqa1 { get; set; }

    public int? Vqs2 { get; set; }

    public string? Vqa2 { get; set; }

    public int? Vqs3 { get; set; }

    public string? Vqa3 { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
