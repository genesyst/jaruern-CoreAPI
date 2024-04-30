using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewTeamsku
{
    public Guid Id { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public Guid? BrandId { get; set; }

    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;

    public Guid? Teamid { get; set; }
}
