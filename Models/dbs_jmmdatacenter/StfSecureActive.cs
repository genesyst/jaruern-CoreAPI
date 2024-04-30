using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfSecureActive
{
    public Guid Id { get; set; }

    public string Syscode { get; set; } = null!;

    public Guid RegSecureId { get; set; }

    public string? Ipaddr { get; set; }

    public string SecureCode { get; set; } = null!;

    public DateTime SecureCodeDate { get; set; }

    public bool Active { get; set; }

    public DateTime? ActiveDate { get; set; }

    public string? ActiveIp { get; set; }
}
