using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewEmployeecont
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string ContNo { get; set; } = null!;

    public string? ContAt { get; set; }

    public DateTime? ContTime { get; set; }

    public Guid? Positionid { get; set; }

    public string? Positionname { get; set; }

    public DateTime ContstDate { get; set; }

    public DateTime? ContenDate { get; set; }

    public int? ContractorAge { get; set; }

    public string? ContractorAddr { get; set; }

    public int? WorkPromonth { get; set; }

    public decimal? Salary { get; set; }

    public string? Tag { get; set; }

    public DateTime Senddate { get; set; }

    public string? ApvOtp { get; set; }

    public DateTime? ApvDate { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string Edostt { get; set; } = null!;
}
