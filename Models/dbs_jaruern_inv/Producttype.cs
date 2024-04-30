using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Producttype
{
    public Guid Id { get; set; }

    public string? Producttypecode { get; set; }

    public string? Producttypename { get; set; }

    public Guid? Teamid { get; set; }

    public bool? Active { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public Guid? UpdateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public Guid CreateBy { get; set; }
}
