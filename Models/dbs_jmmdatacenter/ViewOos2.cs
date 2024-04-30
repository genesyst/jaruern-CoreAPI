using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOos2
{
    public Guid? Id { get; set; }

    public int? Bring { get; set; }

    public string Skuname { get; set; } = null!;

    public Guid ProductskuId { get; set; }

    public int? Atyear { get; set; }

    public int? Atmonth { get; set; }
}
