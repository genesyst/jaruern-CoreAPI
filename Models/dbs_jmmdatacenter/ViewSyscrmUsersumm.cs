using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSyscrmUsersumm
{
    public Guid? Id { get; set; }

    public Guid? Teamid { get; set; }

    public DateTime? Days { get; set; }

    public string? DayDisplay { get; set; }

    public Guid CreateBy { get; set; }

    public string? Empcode { get; set; }

    public string? Empname { get; set; }

    public int? RegisCount { get; set; }

    public int? TelCount { get; set; }

    public int? EmailCount { get; set; }
}
