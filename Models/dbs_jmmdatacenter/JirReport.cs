using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JirReport
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Frmname { get; set; } = null!;

    public int? Level { get; set; }

    public string? Caption { get; set; }
}
