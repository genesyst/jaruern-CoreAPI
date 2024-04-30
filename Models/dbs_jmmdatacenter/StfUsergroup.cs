using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfUsergroup
{
    public Guid Id { get; set; }

    public string Groupcode { get; set; } = null!;

    public string? Groupname { get; set; }

    public Guid Teamid { get; set; }

    public string? Userid { get; set; }

    public bool Notify { get; set; }

    public bool Alluser { get; set; }

    public string? Tag { get; set; }
}
