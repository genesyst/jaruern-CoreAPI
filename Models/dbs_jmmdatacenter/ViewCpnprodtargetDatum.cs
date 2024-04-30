using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCpnprodtargetDatum
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Prodtargetid { get; set; }

    public string? Photoname { get; set; }

    public Guid? Tgstatus { get; set; }

    public string Cpntype { get; set; } = null!;

    public bool? Tghilight { get; set; }

    public Guid Cpnstatusid { get; set; }

    public string Display { get; set; } = null!;
}
