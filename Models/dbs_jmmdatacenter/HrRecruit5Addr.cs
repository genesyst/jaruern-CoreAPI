using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit5Addr
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int Addrindex { get; set; }

    public string? Addr { get; set; }

    public string? ProvinceCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? SubdistrictCode { get; set; }

    public string? Zipcode { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
