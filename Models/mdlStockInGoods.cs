namespace jaruernCore.Models
{
    public class mdlStockInGoods
    {
        public Guid Goodid { get; set; }

        public int Piece { get; set; }

        public Guid UnitId { get; set; }

        public decimal? Saleprice { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Memberprice { get; set; }

        public decimal? Cost { get; set; }

        public string? Remark { get; set; }

        public string? Tag { get; set; }
    }
}
