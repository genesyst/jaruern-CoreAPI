using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewReceptUserpcount
{
    public Guid? Id { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateTime? RecDate { get; set; }

    public int? Prodcount { get; set; }
}
