using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Cnndatum
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public Guid Skuid { get; set; }

    public string Skucode { get; set; } = null!;

    public DateTime Atdate { get; set; }

    public string Cnntype { get; set; } = null!;

    public string Cnnstatus { get; set; } = null!;

    public decimal? Price { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Remark { get; set; }
}
