using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class EdoAw
{
    public Guid Id { get; set; }

    public Guid EdoId { get; set; }

    public string? Otp { get; set; }

    public string? AwsText { get; set; }

    public int? AwsIndex { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
