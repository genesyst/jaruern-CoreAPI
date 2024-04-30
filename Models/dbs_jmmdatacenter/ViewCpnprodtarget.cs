using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCpnprodtarget
{
    public Guid Id { get; set; }

    public int? Priority { get; set; }

    public Guid? Productid { get; set; }

    public Guid? Skuid { get; set; }

    public string? Display { get; set; }

    public string? Tag { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;

    public Guid? Teamid { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public Guid? Storegroupid { get; set; }
}
