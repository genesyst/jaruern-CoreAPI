using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewOftStaff
{
    public Guid? Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Staffid { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public Guid Supid { get; set; }

    public string? Supcode { get; set; }

    public string? Supname { get; set; }

    public Guid Storeid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public int? AmtPiece { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Discount { get; set; }

    public Guid? Teamid { get; set; }

    public string? Teamcode { get; set; }

    public string? Teamname { get; set; }
}
