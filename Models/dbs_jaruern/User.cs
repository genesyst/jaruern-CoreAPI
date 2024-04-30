using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern;

public partial class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string? Empcode { get; set; }

    public string Password { get; set; } = null!;

    public string Secretcode { get; set; } = null!;

    public bool? Activate { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
