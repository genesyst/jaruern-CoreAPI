namespace jaruernCore.Models
{
    public class mdlNewReceript
    {
        public Guid Goodsid { get; set; }
        public int? Piece { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? Cash { get; set; }
        public string CashType { get; set; }
    }
}
