using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewGroupline
{
    public Guid Id { get; set; }

    public string Groupcode { get; set; } = null!;

    public string? Groupname { get; set; }

    public Guid Teamid { get; set; }

    public bool Notify { get; set; }

    public bool Alluser { get; set; }

    public string? Token { get; set; }

    public string? Api { get; set; }

    public bool Sendimg { get; set; }

    public bool Active { get; set; }
}
