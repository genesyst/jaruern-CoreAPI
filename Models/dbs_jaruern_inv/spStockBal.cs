namespace jaruernCore.Models.dbs_jaruern_inv
{
    public class spStockBal
    {
        public Guid Id { get; set; }
        public Guid GoodsId { get; set; }
        public int Piece { get; set; }
        public decimal Cost { get; set; }
    }
}
