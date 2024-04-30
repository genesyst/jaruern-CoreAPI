using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeStoreSale
{
    public Guid Id { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }

    public Guid? Staffid { get; set; }

    public Guid? Storegroupid { get; set; }

    public Guid? Areaid { get; set; }
}
