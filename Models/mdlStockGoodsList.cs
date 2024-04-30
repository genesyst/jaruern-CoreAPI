namespace jaruernCore.Models
{
    public class mdlStockGoodsList
    {
        public Guid Id { get; set; }
        public DateTime Atdate { get; set; }
        public string AtdateStr { get; set; }
        public string CardNo { get; set; }
        public string SkuCode { get; set; }
        public string SkuName { get; set; }
        public string Barcode { get; set; }
        public string QRcode { get; set; }
        public string Size { get; set; }
        public int Piece { get; set; }
        public string Unitname { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Member { get; set; }
        public decimal? Cost { get; set; }
        public string Remark { get; set; }
        public string CreateDate { get; set; }
    }
}
