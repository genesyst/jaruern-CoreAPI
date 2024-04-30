using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ProductPricerate
{
    public Guid Id { get; set; }

    public Guid ProductskuId { get; set; }

    public DateTime? Atdate { get; set; }

    public decimal? Price { get; set; }

    public decimal? PromoPrice { get; set; }

    public decimal? MemberPrice { get; set; }

    public decimal? DiscountPrice { get; set; }

    public string Stt { get; set; } = null!;

    public Guid? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public Guid CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
