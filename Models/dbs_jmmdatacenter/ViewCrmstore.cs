using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrmstore
{
    public Guid? Teamid { get; set; }

    public Guid Id { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Branchcode { get; set; }

    public string? Branchname { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }
}
