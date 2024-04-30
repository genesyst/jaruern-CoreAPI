using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MasThpSubdistrict
{
    public int SubdistrictId { get; set; }

    public string SubdistrictCode { get; set; } = null!;

    public string SubdistrictName { get; set; } = null!;

    public int DistrictId { get; set; }

    public int ProvinceId { get; set; }

    public int GeoId { get; set; }
}
