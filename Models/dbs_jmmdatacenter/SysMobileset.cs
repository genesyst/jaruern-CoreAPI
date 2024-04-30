using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysMobileset
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string? SetKey { get; set; }

    public int? SetValueInt { get; set; }

    public decimal? SetValueDec { get; set; }

    public string? SetValueStr { get; set; }

    public DateTime? SetValueTime { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
