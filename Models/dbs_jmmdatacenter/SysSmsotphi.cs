using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysSmsotphi
{
    public Guid Empid { get; set; }

    public DateTime Requestdate { get; set; }

    public bool? Active { get; set; }
}
