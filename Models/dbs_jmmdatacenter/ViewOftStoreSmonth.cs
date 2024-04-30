using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftStoreSmonth
{
    public Guid? Id { get; set; }

    public int? Aty { get; set; }

    public int? Atm { get; set; }

    public Guid Storeid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public int? SPie { get; set; }

    public decimal? SPrice { get; set; }

    public decimal? SCash { get; set; }

    public decimal? SDis { get; set; }

    public Guid? Teamid { get; set; }
}
