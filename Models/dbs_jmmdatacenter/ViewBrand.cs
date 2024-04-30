using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewBrand
{
    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;

    public string? SubbrandCode { get; set; }

    public string? SubbrandName { get; set; }

    public Guid? Teamid { get; set; }
}
