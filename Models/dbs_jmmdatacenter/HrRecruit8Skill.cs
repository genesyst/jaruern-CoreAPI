using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit8Skill
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public string Thaiskill { get; set; } = null!;

    public string Engskill { get; set; } = null!;

    public string? Langskill { get; set; }

    public string? Comskill { get; set; }

    public string? Other { get; set; }

    public bool Carskill { get; set; }

    public bool Carcert { get; set; }

    public bool Mbikeskill { get; set; }

    public bool Mbikecert { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
