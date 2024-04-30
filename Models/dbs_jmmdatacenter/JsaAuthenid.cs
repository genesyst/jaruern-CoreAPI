using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JsaAuthenid
{
    public Guid Id { get; set; }

    public Guid Teamid { get; set; }

    public string Authcode { get; set; } = null!;

    public bool Active { get; set; }

    public string? Pack { get; set; }

    public string? Secretcode { get; set; }
}
