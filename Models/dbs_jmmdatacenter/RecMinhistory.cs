using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMinhistory
{
    public Guid Id { get; set; }

    public Guid PositionId { get; set; }

    public int? SalaryReq { get; set; }

    public string? Tname { get; set; }

    public string Fname { get; set; } = null!;

    public string? Lname { get; set; }

    public string Nname { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Sex { get; set; } = null!;

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public string Status { get; set; } = null!;

    public string Nat { get; set; } = null!;

    public string Reg { get; set; } = null!;

    public string Soldstatus { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Validcode { get; set; }
}
