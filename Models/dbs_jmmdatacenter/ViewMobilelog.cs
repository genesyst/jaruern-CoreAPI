using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewMobilelog
{
    public int Id { get; set; }

    public DateTime? Logtime { get; set; }

    public string? Os { get; set; }

    public string? Syscode { get; set; }

    public string? Empid { get; set; }

    public string? Empcode { get; set; }

    public string? Empname { get; set; }

    public string? Teamid { get; set; }

    public string? Source { get; set; }

    public string? Msg { get; set; }
}
