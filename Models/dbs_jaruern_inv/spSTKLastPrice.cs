namespace jaruernCore.Models.dbs_jaruern_inv
{
    public class spSTKLastPrice
    {
        public Guid Id { get; set; }
        public decimal SalePrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? MemberPrice { get; set; }
        public decimal? Cost { get; set; }
    }
}
