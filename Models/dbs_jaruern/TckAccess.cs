using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern;

public partial class TckAccess
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public Guid Userid { get; set; }

    public string Usercode { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime CreateDate { get; set; }
}
