using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ComGroup
{
    public Guid Id { get; set; }

    public Guid Groupid { get; set; }

    public string Groupname { get; set; } = null!;

    public string? Groupdesc { get; set; }

    public Guid Ownerid { get; set; }

    public string Grouptype { get; set; } = null!;

    public bool Ispublic { get; set; }

    public Guid? Teamid { get; set; }

    public string? Groupkey { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
