using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class Running
{
    public Guid Id { get; set; }

    public Guid Storeid { get; set; }

    public string Typename { get; set; } = null!;

    public string Keycode { get; set; } = null!;

    public int Value { get; set; }

    public DateTime Lastupdate { get; set; }
}
