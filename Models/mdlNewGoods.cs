namespace jaruernCore.Models
{
    public class mdlNewGoods
    {
        public string Skubarcode { get; set; } = null!;

        public string? Skuqrcode { get; set; }

        public string Skucode { get; set; } = null!;

        public string Skuname { get; set; } = null!;

        public string? Desp { get; set; }

        public string? Skudisplayname { get; set; }

        public Guid? Productgroupid { get; set; }

        public Guid? Producttypeid { get; set; }

        public string? Skusize { get; set; }

    }
}
