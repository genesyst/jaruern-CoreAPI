using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfRegsecure
{
    public Guid Id { get; set; }

    public Guid Empid { get; set; }

    public string Tel { get; set; } = null!;

    public string? Email { get; set; }

    public string? Lineid { get; set; }

    public string? LineToken { get; set; }

    public string? FcmToken { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
