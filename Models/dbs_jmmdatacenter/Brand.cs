using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Brand
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;

    public Guid? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
