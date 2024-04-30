using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Crmaddr
{
    public Guid Id { get; set; }

    public Guid Customerid { get; set; }

    public string? HouseNo { get; set; }

    public string? Moo { get; set; }

    public string? Building { get; set; }

    public string? Soi { get; set; }

    public string? Road { get; set; }

    public string? SubdistrictCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? ProvinceCode { get; set; }

    public string? Zipcode { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
