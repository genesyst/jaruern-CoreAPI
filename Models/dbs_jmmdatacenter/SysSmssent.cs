using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysSmssent
{
    public Guid Id { get; set; }

    public bool Sent { get; set; }

    public bool Err { get; set; }

    public string Telnumber { get; set; } = null!;

    public string? Smsid { get; set; }

    public string? MessageTxt { get; set; }
}
