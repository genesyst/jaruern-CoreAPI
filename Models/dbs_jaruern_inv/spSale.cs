namespace jaruernCore.Models.dbs_jaruern_inv
{
    public class spSale
    {
        public Guid Id { get; set; }
        public Guid GoodsId { get; set; }
        public int Piece { get; set; }
        public decimal Cash { get; set; }
    }
}
