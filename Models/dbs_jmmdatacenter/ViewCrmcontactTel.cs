using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrmcontactTel
{
    public Guid? Id { get; set; }

    public string? Dtel { get; set; }

    public int? Dyear { get; set; }

    public int? Dmonth { get; set; }

    public int? Dday { get; set; }
}
