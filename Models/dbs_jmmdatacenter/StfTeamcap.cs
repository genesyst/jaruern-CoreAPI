using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfTeamcap
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public string Defaultcap { get; set; } = null!;

    public string? Transcap { get; set; }
}
