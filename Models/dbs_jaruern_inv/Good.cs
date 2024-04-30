using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Good
{
    public Guid Id { get; set; }

    public string Skubarcode { get; set; } = null!;

    public string? Skuqrcode { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skusize { get; set; }

    public string? Desp { get; set; }

    public string? Skudisplayname { get; set; }

    public Guid? Productid { get; set; }

    public Guid? Productgroupid { get; set; }

    public Guid? Producttypeid { get; set; }

    public Guid? Teamid { get; set; }

    public string? Tag { get; set; }

    public bool? Active { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid CreateBy { get; set; }
}
