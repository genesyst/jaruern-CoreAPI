using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MasThpZipcode
{
    public int Id { get; set; }

    public string DistrictCode { get; set; } = null!;

    public string Zipcode { get; set; } = null!;
}
