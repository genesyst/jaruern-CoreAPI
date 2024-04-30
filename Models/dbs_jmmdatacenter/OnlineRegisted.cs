using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class OnlineRegisted
{
    public Guid Id { get; set; }

    public Guid Regisid { get; set; }

    public Guid Empid { get; set; }

    public string? Location { get; set; }

    public decimal? Distance { get; set; }

    public bool? ValidateLocation { get; set; }

    public string? Imagefile { get; set; }

    public string? Ip { get; set; }

    public string? Otp { get; set; }

    public string Stt { get; set; } = null!;

    public DateTime? CreateDate { get; set; }
}
