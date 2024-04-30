using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Crmregi
{
    public Guid Id { get; set; }

    public Guid? Teamid { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int? Relation { get; set; }

    public DateTime? Regisdate { get; set; }

    public string? Regisgroup { get; set; }

    public string? Contdays { get; set; }

    public int? Conttime { get; set; }

    public string? RefFirstname { get; set; }

    public string? RefLastname { get; set; }

    public DateTime? RefBirthdate { get; set; }

    public int? RefYage { get; set; }

    public int? RefMage { get; set; }

    public string? GetProductFrom { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? Storeid { get; set; }

    public DateTime? Maternity { get; set; }
}
