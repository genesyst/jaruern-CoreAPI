using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrPdpaPermiss
{
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public string AcceptVal { get; set; } = null!;

    public string? Teamids { get; set; }
}
