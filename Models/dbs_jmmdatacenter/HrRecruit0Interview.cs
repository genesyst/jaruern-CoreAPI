using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit0Interview
{
    public Guid Id { get; set; }

    public Guid Hid { get; set; }

    public DateTime InterviewDate { get; set; }

    public string? InterviewRemark { get; set; }

    public string? InterviewStatus { get; set; }

    public Guid UpdateBy { get; set; }

    public DateTime UpdateDate { get; set; }
}
