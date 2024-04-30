using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Product
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public Guid? BrandId { get; set; }

    public Guid? ProducttypeId { get; set; }

    public string? Tag { get; set; }

    public bool? Discontinued { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
