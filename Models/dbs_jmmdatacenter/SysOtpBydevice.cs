using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class SysOtpBydevice
{
    public Guid Id { get; set; }

    public DateTime RequestDate { get; set; }

    public Guid Empid { get; set; }

    public string Tel { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public string? ObjectiveCode { get; set; }

    public bool Active { get; set; }

    public DateTime? ActiveDate { get; set; }
}
