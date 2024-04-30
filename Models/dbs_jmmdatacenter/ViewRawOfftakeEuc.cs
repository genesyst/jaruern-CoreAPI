using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewRawOfftakeEuc
{
    public Guid Empid { get; set; }

    public string Empcode { get; set; } = null!;

    public string Titlename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public bool Active { get; set; }

    public string EmpStt { get; set; } = null!;

    public Guid? Storeid { get; set; }

    public string Storecode { get; set; } = null!;

    public string Storename { get; set; } = null!;

    public string StoreStt { get; set; } = null!;

    public string Areacode { get; set; } = null!;

    public string Areaname { get; set; } = null!;

    public string AreaStt { get; set; } = null!;

    public DateTime Atdate { get; set; }

    public decimal? Pay { get; set; }

    public decimal? Realprice { get; set; }

    public string? ReceiptRemark { get; set; }

    public string ReceiptStt { get; set; } = null!;

    public Guid ProductskuId { get; set; }

    public decimal? Price { get; set; }

    public int? Amtout { get; set; }

    public decimal? Allpay { get; set; }

    public decimal? Allrealprice { get; set; }

    public decimal? Alldiscount { get; set; }

    public string? ProdRemark { get; set; }

    public string ProdStt { get; set; } = null!;

    public string Skucode { get; set; } = null!;

    public string Skuname { get; set; } = null!;

    public string? Skubarcode { get; set; }

    public Guid ProductId { get; set; }

    public string? Skudisplay { get; set; }

    public string Productcode { get; set; } = null!;

    public string Productname { get; set; } = null!;

    public Guid? BrandId { get; set; }

    public string Brandcode { get; set; } = null!;

    public string Brandname { get; set; } = null!;
}
