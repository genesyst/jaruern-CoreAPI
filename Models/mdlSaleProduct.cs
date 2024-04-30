using jaruernCore.Models.dbs_jaruern_inv;

namespace jaruernCore.Models
{
    public class mdlSaleProduct : spGoodsForSale
    {
        public int Amt_Pie { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Member { get; set; }
    }
}
