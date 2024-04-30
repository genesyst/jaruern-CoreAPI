using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class IntDocrunning
{
    public string Doccode { get; set; } = null!;

    public int Runyear { get; set; }

    public int Runno { get; set; }

    public DateTime Lastupdate { get; set; }
}
