using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Crmcontact
{
    public Guid Id { get; set; }

    public Guid Customerid { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public string? Fb { get; set; }

    public string? Ig { get; set; }

    public string? Twit { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
