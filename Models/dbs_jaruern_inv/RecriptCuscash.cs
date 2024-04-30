using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class RecriptCuscash
{
    public Guid Id { get; set; }

    public Guid Recriptid { get; set; }

    public string Cashtype { get; set; } = null!;

    public decimal Cuscash { get; set; }

    public decimal Cuscashchang { get; set; }

    public string? Creditno { get; set; }

    public decimal? Cuscredit { get; set; }
}
