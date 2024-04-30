using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrmregi
{
    public Guid Id { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public DateTime? Regisdate { get; set; }

    public Guid? Teamid { get; set; }

    public string? Regisgroup { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? Storeid { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }
}
