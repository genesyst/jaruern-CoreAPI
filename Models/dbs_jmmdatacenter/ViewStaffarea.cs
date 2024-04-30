using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewStaffarea
{
    public Guid? Id { get; set; }

    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public Guid? Areaid { get; set; }
}
