using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class AttleaveApv
{
    public Guid Id { get; set; }

    public Guid Leaveid { get; set; }

    public Guid? Apvid1 { get; set; }

    public DateTime? Apv1date { get; set; }

    public bool? Apv1stt { get; set; }

    public string? Remark1 { get; set; }

    public Guid? Apvid2 { get; set; }

    public DateTime? Apv2date { get; set; }

    public bool? Apv2stt { get; set; }

    public string? Remark2 { get; set; }

    public Guid? Apvid3 { get; set; }

    public DateTime? Apv3date { get; set; }

    public bool? Apv3stt { get; set; }

    public string? Remark3 { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
