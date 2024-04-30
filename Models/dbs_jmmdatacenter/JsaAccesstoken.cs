using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JsaAccesstoken
{
    public Guid Id { get; set; }

    public Guid Tokenid { get; set; }

    public Guid Authid { get; set; }

    public string Token { get; set; } = null!;

    public bool Active { get; set; }

    public int Accesslimit { get; set; }

    public DateTime CreateDate { get; set; }
}
