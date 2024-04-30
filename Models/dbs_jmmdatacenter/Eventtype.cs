﻿using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Eventtype
{
    public Guid Id { get; set; }

    public int? Seq { get; set; }

    public string Eventcode { get; set; } = null!;

    public string Eventname { get; set; } = null!;

    public string Evtype { get; set; } = null!;

    public string? Tag { get; set; }

    public string? Teamid { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
