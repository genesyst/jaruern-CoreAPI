using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JsaActionlog
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? Msg { get; set; }

    public DateTime CreateDate { get; set; }
}
