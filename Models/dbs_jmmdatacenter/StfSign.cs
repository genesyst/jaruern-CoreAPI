using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfSign
{
    public Guid Id { get; set; }

    public string Userid { get; set; } = null!;

    public string Userpw { get; set; } = null!;

    public string Secretcode { get; set; } = null!;

    public bool? Activate { get; set; }

    public string? Teamid { get; set; }

    public int? Level { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Token { get; set; }

    public string? Refercode { get; set; }
}
