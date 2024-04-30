using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMinskilllang
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public string Language { get; set; } = null!;

    public int SkRead { get; set; }

    public int SkWrit { get; set; }

    public int? SkSpek { get; set; }
}
