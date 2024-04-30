using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewEdoDocaccept2
{
    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string? Teamid { get; set; }

    public string? Dcode { get; set; }

    public string? Docstt { get; set; }
}
