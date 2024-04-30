using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysAppupdate
{
    public Guid Id { get; set; }

    public string Appid { get; set; } = null!;

    public string Versioncode { get; set; } = null!;

    public string? Appurl { get; set; }

    public string? Descurl { get; set; }
}
