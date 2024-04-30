using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Sett
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public string Setkey { get; set; } = null!;

    public string? SetvalStr { get; set; }

    public int? SetvalInt { get; set; }

    public decimal? SetvalDou { get; set; }

    public bool? Active { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid CreateBy { get; set; }
}
