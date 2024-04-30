namespace jaruernCore.Models.dbs_jaruern_inv
{
    public class spGoodsInStock
    {
        public Guid Id { get; set; }
        public Guid GoodId { get; set; }
        public string SkuBarcode { get; set; }
        public string SkuQRcode { get; set; }
        public string Skucode { get; set; }
        public string Skuname { get; set; }
        public string Skusize { get; set; }
    }
}
