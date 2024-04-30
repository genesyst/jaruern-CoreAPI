namespace jaruernCore.Models
{
    public class mdlStockInCard
    {
        public string Atdate { get; set; }

        public Guid Storeid { get; set; }

        public string? Remark { get; set; }

        public string? Tag { get; set; }

        public string Culture { get; set; }

        public List<mdlStockInGoods> StockInGoods { get; set; }
    }
}
