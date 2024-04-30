using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MasCrmcalltime
{
    public Guid Id { get; set; }

    public int Idx { get; set; }

    public string? Display { get; set; }

    public string? Disc { get; set; }

    public Guid? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
