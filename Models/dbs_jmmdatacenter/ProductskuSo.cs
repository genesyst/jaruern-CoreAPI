using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ProductskuSo
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Storeid { get; set; }

    public Guid Skuid { get; set; }

    public Guid? Shelftypeid { get; set; }

    public int? ShelfW { get; set; }

    public int? ShelfL { get; set; }

    public int? ShelfH { get; set; }

    public string? Remark { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
