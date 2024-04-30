using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewAttmonthIo
{
    public Guid? Id { get; set; }

    public Guid Userid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public Guid? Deptid { get; set; }

    public string Deptname { get; set; } = null!;

    public int? Ydate { get; set; }

    public int? Mdate { get; set; }

    public int? Checkin { get; set; }

    public int? Checkout { get; set; }
}
