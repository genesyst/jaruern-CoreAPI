using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewSalaryhi
{
    public Guid? Id { get; set; }

    public Guid Teamid { get; set; }

    public string? Teamname { get; set; }

    public string? Teamdesp { get; set; }

    public int? Atyear { get; set; }

    public int? Atmonth { get; set; }

    public int? Data { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid Hid { get; set; }
}
