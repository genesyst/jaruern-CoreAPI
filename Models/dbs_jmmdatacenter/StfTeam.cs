using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfTeam
{
    public Guid Id { get; set; }

    public string Teamcode { get; set; } = null!;

    public string Teamname { get; set; } = null!;

    public string? Desp { get; set; }

    public string? FunctionConf { get; set; }

    public Guid? Companyid { get; set; }

    public string? Domain { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
