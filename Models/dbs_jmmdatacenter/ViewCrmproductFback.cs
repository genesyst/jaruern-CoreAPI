using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrmproductFback
{
    public Guid Id { get; set; }

    public Guid Customerid { get; set; }

    public Guid? Productid { get; set; }

    public string? Productname { get; set; }

    public string? ProductOth { get; set; }

    public string? Remark { get; set; }
}
