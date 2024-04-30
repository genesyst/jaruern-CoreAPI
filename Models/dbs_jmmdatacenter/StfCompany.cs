using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class StfCompany
{
    public Guid Id { get; set; }

    public string Compcode { get; set; } = null!;

    public string Compname { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }
}
