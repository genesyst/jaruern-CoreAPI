using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftAccSmonth2
{
    public Guid? Id { get; set; }

    public int? Aty { get; set; }

    public int? Atm { get; set; }

    public Guid Supid { get; set; }

    public string? Supcode { get; set; }

    public string? Supname { get; set; }

    public Guid? Storegroupid { get; set; }

    public int? Smt { get; set; }

    public decimal? Scash { get; set; }

    public Guid? Teamid { get; set; }

    public Guid Storeid { get; set; }

    public Guid? Areaid { get; set; }
}
