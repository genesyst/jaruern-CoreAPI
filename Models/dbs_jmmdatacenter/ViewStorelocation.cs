using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStorelocation
{
    public Guid Id { get; set; }

    public Guid Staffid { get; set; }

    public Guid? Storeid { get; set; }

    public string Gps { get; set; } = null!;
}
