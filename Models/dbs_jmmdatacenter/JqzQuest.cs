using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JqzQuest
{
    public Guid Id { get; set; }

    public Guid Zid { get; set; }

    public int Seq { get; set; }

    public string Quest { get; set; } = null!;

    public int? Priority { get; set; }

    /// <summary>
    /// 1=boolean / 2=text / 3=choise / 4 = multiselect
    /// </summary>
    public int Atype { get; set; }

    public string Stt { get; set; } = null!;

    public bool? IsforceValie { get; set; }
}
