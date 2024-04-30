using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class StkCard
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public string Cardno { get; set; } = null!;

    public Guid Storeid { get; set; }

    public string? Remark { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid CreateBy { get; set; }
}
