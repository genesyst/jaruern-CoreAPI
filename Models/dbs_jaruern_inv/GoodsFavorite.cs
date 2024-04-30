using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class GoodsFavorite
{
    public Guid Id { get; set; }

    public Guid Goodsid { get; set; }

    public Guid Userid { get; set; }

    public DateTime CreateDate { get; set; }
}
