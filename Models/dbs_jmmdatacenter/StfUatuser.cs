using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfUatuser
{
    public int Id { get; set; }

    public Guid Empid { get; set; }

    public Guid Teamid { get; set; }

    public string? Tag { get; set; }
}
