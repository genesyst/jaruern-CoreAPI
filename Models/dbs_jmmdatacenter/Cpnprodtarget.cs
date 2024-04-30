using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Cpnprodtarget
{
    public Guid Id { get; set; }

    public int? Priority { get; set; }

    public Guid? Productid { get; set; }

    public Guid? Skuid { get; set; }

    public string? Display { get; set; }

    public string? Tag { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? Atdate { get; set; }

    public Guid? Storeid { get; set; }

    public Guid? Storegroupid { get; set; }

    public Guid? Cpnid { get; set; }
}
