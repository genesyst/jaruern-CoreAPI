using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewJsaacclog
{
    public Guid? Id { get; set; }

    public Guid Teamid { get; set; }

    public string? Auth { get; set; }

    public DateTime CreateDate { get; set; }
}
