using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class AttleaveImg
{
    public Guid Id { get; set; }

    public Guid Userid { get; set; }

    public string? ImgBase64 { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? CreateDate { get; set; }
}
