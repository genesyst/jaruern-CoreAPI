using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttmonth
{
    public Guid? Id { get; set; }

    public int? Stm { get; set; }

    public int? Sty { get; set; }

    public Guid Userid { get; set; }

    public Guid? Storeid { get; set; }

    public int? Stcount { get; set; }
}
