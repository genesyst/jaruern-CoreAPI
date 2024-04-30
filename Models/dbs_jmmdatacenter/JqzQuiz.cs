using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JqzQuiz
{
    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? Desp { get; set; }

    public DateTime? ExpireDate { get; set; }

    public Guid? Teamid { get; set; }

    public string? Utype { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
