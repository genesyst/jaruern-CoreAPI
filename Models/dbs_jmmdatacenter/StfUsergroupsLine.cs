using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfUsergroupsLine
{
    public Guid Id { get; set; }

    public Guid Usergroupid { get; set; }

    public string? Token { get; set; }

    public string? Api { get; set; }

    public bool Sendimg { get; set; }

    public bool Active { get; set; }

    public DateTime CreateDate { get; set; }
}
