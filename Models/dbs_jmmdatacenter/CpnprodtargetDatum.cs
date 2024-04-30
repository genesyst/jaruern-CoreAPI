using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class CpnprodtargetDatum
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Prodtargetid { get; set; }

    public string? Photoname { get; set; }

    public Guid? Tgstatus { get; set; }

    public string Cpntype { get; set; } = null!;

    public bool? Tghilight { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Cpncount { get; set; }
}
