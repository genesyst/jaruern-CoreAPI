using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EdoResign
{
    public Guid Id { get; set; }

    public DateTime Atdate { get; set; }

    public Guid Empid { get; set; }

    public DateTime Startwork { get; set; }

    public string Posname { get; set; } = null!;

    public string Deptname { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public DateTime Lastwork { get; set; }

    public int Apvlevel { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
