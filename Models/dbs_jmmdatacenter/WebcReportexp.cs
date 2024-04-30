using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class WebcReportexp
{
    public Guid Id { get; set; }

    public string Taskname { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string Taskdisplay { get; set; } = null!;

    public string? Description { get; set; }

    public string? Accessdept { get; set; }

    public int? Accesslevel { get; set; }

    public string? Fileformat { get; set; }

    public string? Filenameformat { get; set; }

    public int? Priority { get; set; }

    public Guid? Teamid { get; set; }

    public string Syscode { get; set; } = null!;

    public string Stt { get; set; } = null!;

    public string? Criteria { get; set; }
}
