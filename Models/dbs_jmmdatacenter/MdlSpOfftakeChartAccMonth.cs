using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeChartAccMonth
{
    public Guid Id { get; set; }

    public string? Storegroupname { get; set; }

    public decimal? Cash { get; set; }

    public Guid? Areaid { get; set; }
}
