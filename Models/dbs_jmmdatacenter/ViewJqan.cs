using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewJqan
{
    public string? Title { get; set; }

    public string Quest { get; set; } = null!;

    public Guid? ChoiceId { get; set; }

    public string? Anstext { get; set; }

    public string? Textvalue { get; set; }

    public bool? Boolvalue { get; set; }

    public int? Weight { get; set; }

    public Guid Id { get; set; }

    public Guid Uid { get; set; }

    public Guid Qid { get; set; }

    public DateTime CreateDate { get; set; }
}
