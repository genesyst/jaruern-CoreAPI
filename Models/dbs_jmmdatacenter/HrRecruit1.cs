using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class HrRecruit1
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Privatecode { get; set; } = null!;

    public Guid Resourceid { get; set; }

    public int? Compensation { get; set; }

    public DateTime? Startwork { get; set; }

    public string? Ttname { get; set; }

    public string? Tfname { get; set; }

    public string? Tlname { get; set; }

    public string? Tnic { get; set; }

    public string? Etname { get; set; }

    public string? Efname { get; set; }

    public string? Elname { get; set; }

    public string? Enic { get; set; }

    public string Idcard { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string? Birthplace { get; set; }

    public string Sex { get; set; } = null!;

    public int? Higth { get; set; }

    public int? Weight { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public string? MarrriageCert { get; set; }

    public string Origin { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string Religion { get; set; } = null!;

    public string Military { get; set; } = null!;

    public string? Taxno { get; set; }

    public string? Socno { get; set; }

    public string? Hosno { get; set; }

    public DateTime? Certexp { get; set; }

    public string? Email { get; set; }

    public string Tel1 { get; set; } = null!;

    public string? Tel2 { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Certno { get; set; }
}
