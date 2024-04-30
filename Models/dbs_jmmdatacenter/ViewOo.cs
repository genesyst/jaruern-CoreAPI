using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOo
{
    public Guid Id { get; set; }

    public Guid ProductskuId { get; set; }

    public Guid IvtstatusId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public Guid? StoreId { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Remark { get; set; }

    public int? Bring { get; set; }

    public string? Teamid { get; set; }

    public Guid? Areaid { get; set; }

    public Guid? Storegroupid { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public DateTime Atdate { get; set; }
}
