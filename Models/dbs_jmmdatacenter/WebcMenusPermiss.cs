using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class WebcMenusPermiss
{
    public Guid Id { get; set; }

    public Guid Menuid { get; set; }

    public Guid Deptid { get; set; }

    public Guid Teamid { get; set; }

    public string Syscode { get; set; } = null!;
}
