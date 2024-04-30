namespace jaruernCore.Models.dbs_jaruern_inv
{
    public class spGoodsForSale
    {
        public Guid Id { get; set; }
        public Guid GoodsId { get; set; }
        public int Stk_Pie { get; set; }
        public int Sale_Pie { get; set; }
        public string SkuBarcode { get; set; }
        public string SkuQRcode { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
    }
}
