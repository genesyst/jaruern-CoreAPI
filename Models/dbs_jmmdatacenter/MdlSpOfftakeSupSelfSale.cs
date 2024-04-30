using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MdlSpOfftakeSupSelfSale
{
    public Guid Id { get; set; }

    public Guid? Storeid { get; set; }

    public string? Storecode { get; set; }

    public string? Storename { get; set; }

    public int? Amt { get; set; }

    public decimal? Total { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Disc { get; set; }
}
