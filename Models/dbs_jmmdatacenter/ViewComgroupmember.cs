using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewComgroupmember
{
    public Guid Id { get; set; }

    public Guid Groupid { get; set; }

    public Guid Userid { get; set; }

    public string? Userdisplay { get; set; }

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public string Deptcode { get; set; } = null!;

    public string Deptname { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string Empcode { get; set; } = null!;
}
