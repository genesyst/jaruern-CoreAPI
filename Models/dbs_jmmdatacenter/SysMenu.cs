using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysMenu
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string DisplayTitle { get; set; } = null!;

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? Active { get; set; }
}
