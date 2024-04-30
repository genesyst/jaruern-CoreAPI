using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrmtel
{
    public Guid Id { get; set; }

    public Guid? Teamid { get; set; }

    public string CustomerCode { get; set; } = null!;

    public DateTime? Regisdate { get; set; }

    public Guid? Storeid { get; set; }

    public string? Tel { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Empcode { get; set; } = null!;

    public string? Empname { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public Guid? Productid { get; set; }

    public string Productname { get; set; } = null!;
}
