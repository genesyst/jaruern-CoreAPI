using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfAvatar
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public byte[]? PersonalImg { get; set; }

    public int? Version { get; set; }

    public bool? Active { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
