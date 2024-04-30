using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ComGroupmember
{
    public Guid Id { get; set; }

    public Guid Groupid { get; set; }

    public Guid Userid { get; set; }

    public string? Userdisplay { get; set; }

    public string? Groupkey { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
