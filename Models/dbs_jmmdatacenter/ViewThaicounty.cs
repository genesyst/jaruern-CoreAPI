using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewThaicounty
{
    public string SubdistrictName { get; set; } = null!;

    public string SubdistrictCode { get; set; } = null!;

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? ProvinceCode { get; set; }

    public string? ProvinceName { get; set; }

    public int GeoId { get; set; }

    public string GeoName { get; set; } = null!;

    public string? Zipcode { get; set; }
}
