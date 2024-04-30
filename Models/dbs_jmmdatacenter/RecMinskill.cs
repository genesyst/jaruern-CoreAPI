using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class RecMinskill
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public string? SkillComp { get; set; }

    public string? SkillOth { get; set; }

    public string SkillCar { get; set; } = null!;

    public string CarLicense { get; set; } = null!;

    public string SkillMbike { get; set; } = null!;

    public string MbikeLicense { get; set; } = null!;
}
