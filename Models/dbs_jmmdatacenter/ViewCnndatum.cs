using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCnndatum
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public Guid Skuid { get; set; }

    public string Skucode { get; set; } = null!;

    public DateTime Atdate { get; set; }

    public string Cnntype { get; set; } = null!;

    public string Cnnstatus { get; set; } = null!;

    public decimal? Price { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Remark { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public Guid? Areaid { get; set; }

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string? Teamid { get; set; }

    public string Skuname { get; set; } = null!;

    public string? Skudisplay { get; set; }
}
