using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewTeammenu
{
    public Guid Id { get; set; }

    public Guid? Teamid { get; set; }

    public string? Display { get; set; }

    public string Code { get; set; } = null!;

    public string DisplayTitle { get; set; } = null!;

    public string? DeptidsPermiss { get; set; }
}
