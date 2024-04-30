using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class TestPermit
{
    public Guid? Id { get; set; }

    public int? Seq { get; set; }

    public string? Brandcode { get; set; }

    public string? Brandname { get; set; }

    public Guid? Teamid { get; set; }

    public string? Stt { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
