using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfSignature
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Signkey { get; set; } = null!;

    public string? Stt { get; set; }

    public DateTime CreateDate { get; set; }
}
