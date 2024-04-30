using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MasThpDistrict
{
    public int DistrictId { get; set; }

    public string DistrictCode { get; set; } = null!;

    public string DistrictName { get; set; } = null!;

    public int GeoId { get; set; }

    public int ProvinceId { get; set; }
}
