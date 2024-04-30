using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewHrrecruitAddr
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int Addrindex { get; set; }

    public string? Addr { get; set; }

    public string? ProvinceCode { get; set; }

    public string ProvinceName { get; set; } = null!;

    public string? DistrictCode { get; set; }

    public string DistrictName { get; set; } = null!;

    public string? SubdistrictCode { get; set; }

    public string SubdistrictName { get; set; } = null!;

    public string? Zipcode { get; set; }

    public DateTime? CreateDate { get; set; }
}
