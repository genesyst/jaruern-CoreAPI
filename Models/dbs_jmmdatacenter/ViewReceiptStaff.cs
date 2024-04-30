using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewReceiptStaff
{
    public Guid? Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Storeid { get; set; }

    public Guid Staffid { get; set; }

    public int? AmtPiece { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Discount { get; set; }

    public Guid? Teamid { get; set; }
}
