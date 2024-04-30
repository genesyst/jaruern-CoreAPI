using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Store
{
    public Guid Id { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string? Branchcode { get; set; }

    public string? Branchname { get; set; }

    public int? Priority { get; set; }

    public Guid? Areaid { get; set; }

    public Guid? Storegroupid { get; set; }

    public Guid? Storetypeid { get; set; }

    public string? Desp { get; set; }

    public string? Tag { get; set; }

    public string? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Storedisplay { get; set; }
}
