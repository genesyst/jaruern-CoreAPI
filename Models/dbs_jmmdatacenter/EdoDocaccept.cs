using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EdoDocaccept
{
    public Guid Id { get; set; }

    public int Runid { get; set; }

    public string Dcode { get; set; } = null!;

    public Guid Empid { get; set; }

    public string? Doccontent { get; set; }

    public string? Docvalue { get; set; }

    public string? Docstt { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime CreateDate { get; set; }
}
