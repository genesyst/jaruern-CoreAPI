using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class OnlineRegistration
{
    public Guid Id { get; set; }

    public string Regcode { get; set; } = null!;

    public string Regname { get; set; } = null!;

    public string RegType { get; set; } = null!;

    public string? Description { get; set; }

    public string? Place { get; set; }

    public string? Schedule { get; set; }

    public DateTime ActiveDate { get; set; }

    public DateTime? DeactiveDate { get; set; }

    public string? GpsLat { get; set; }

    public string? GpsLng { get; set; }

    public int? PersonLimit { get; set; }

    public Guid? Teamid { get; set; }

    public string? Linetoken { get; set; }

    public string? Report2mail { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
