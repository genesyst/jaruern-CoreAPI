using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Oo
{
    public Guid Id { get; set; }

    public Guid ProductskuId { get; set; }

    public Guid IvtstatusId { get; set; }

    public DateTime Atdate { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? StoreId { get; set; }

    public string? Stocktype { get; set; }

    public int? Bring { get; set; }

    public string? Remark { get; set; }
}
