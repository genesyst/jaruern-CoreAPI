using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Cpndatum
{
    public Guid Id { get; set; }

    public Guid Masterid { get; set; }

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public decimal? Value { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
