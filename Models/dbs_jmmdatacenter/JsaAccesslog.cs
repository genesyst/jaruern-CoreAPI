using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JsaAccesslog
{
    public Guid Id { get; set; }

    public Guid Tokenid { get; set; }

    public int Accessed { get; set; }

    public DateTime CreateDate { get; set; }

    public string? AccessFunc { get; set; }
}
