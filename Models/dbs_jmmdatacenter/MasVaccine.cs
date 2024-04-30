using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class MasVaccine
{
    public Guid Id { get; set; }

    public string VacCode { get; set; } = null!;

    public string VacThname { get; set; } = null!;

    public string VacEnname { get; set; } = null!;

    public string VacType { get; set; } = null!;

    public string? Desp { get; set; }

    public string? Tag { get; set; }

    public int Prior { get; set; }

    public string Stt { get; set; } = null!;
}
