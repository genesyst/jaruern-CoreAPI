using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JqzAnsval
{
    public Guid Id { get; set; }

    public Guid Uid { get; set; }

    public Guid Qid { get; set; }

    public Guid? ChoiceId { get; set; }

    public string? Textvalue { get; set; }

    public bool? Boolvalue { get; set; }

    public int? Weight { get; set; }

    public DateTime CreateDate { get; set; }
}
