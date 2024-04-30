using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit7Edu
{
    public Guid Id { get; set; }

    public Guid Rid { get; set; }

    public int Eduindex { get; set; }

    public string Edulevel { get; set; } = null!;

    public string InstituteName { get; set; } = null!;

    public string? Major { get; set; }

    public string? Grad { get; set; }

    public int Startyear { get; set; }

    public int Endyear { get; set; }

    public string? Certname { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
