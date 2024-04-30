using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewProductCompet
{
    public Guid Id { get; set; }

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public Guid ProductId { get; set; }

    public string? Tag { get; set; }

    public string? Skudisplay { get; set; }
}
