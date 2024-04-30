using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewJqzan
{
    public Guid? Id { get; set; }

    public Guid? Empid { get; set; }

    public string? Idcard { get; set; }

    public Guid Zid { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid Quizuser { get; set; }
}
