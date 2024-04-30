using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfUsertoken
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string Ttype { get; set; } = null!;

    public string Tokencode { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public DateTime UpdateDate { get; set; }
}
