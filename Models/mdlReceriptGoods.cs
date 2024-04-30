namespace jaruernCore.Models
{
    public class mdlReceriptGoods
    {
        public Guid Id { get; set; }
        public Guid Goodsid { get; set; }
        public string GoodsName { get; set; }
        public string Barcode { get; set; }
        public string QrCode { get; set; }
        public string Size { get; set; }

        public int? Piece { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? Cash { get; set; }
        public string CashType { get; set; }

        public string Recode { get; set; }
        public string Rereason { get; set; }
    }
}
