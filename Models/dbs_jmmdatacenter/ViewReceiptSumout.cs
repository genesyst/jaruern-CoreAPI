using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewReceiptSumout
{
    public Guid? Id { get; set; }

    public Guid Storeid { get; set; }

    public Guid ProductskuId { get; set; }

    public int? Sumamtout { get; set; }
}
