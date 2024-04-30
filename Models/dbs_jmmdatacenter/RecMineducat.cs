using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMineducat
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public int Seq { get; set; }

    public string EdulevCode { get; set; } = null!;

    public string School { get; set; } = null!;

    public string? Major { get; set; }

    public decimal? Grade { get; set; }

    public int? Startyear { get; set; }

    public int? Endyear { get; set; }
}
