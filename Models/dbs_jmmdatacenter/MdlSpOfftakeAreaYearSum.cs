using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeAreaYearSum
{
    public Guid Id { get; set; }

    public int? Areamonth { get; set; }

    public Guid? Areaid { get; set; }

    public string? Areacode { get; set; }

    public string? Areaname { get; set; }

    public decimal? Price { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }
}
