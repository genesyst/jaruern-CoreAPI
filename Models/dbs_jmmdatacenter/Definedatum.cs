using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class Definedatum
{
    public Guid Id { get; set; }

    public string Syscode { get; set; } = null!;

    public Guid Teamid { get; set; }

    public string Code { get; set; } = null!;

    public string? Value { get; set; }

    public string? Name { get; set; }

    public string? Descript { get; set; }

    public int? Seq { get; set; }

    public string? Typecode { get; set; }

    public string? Tag { get; set; }
}
