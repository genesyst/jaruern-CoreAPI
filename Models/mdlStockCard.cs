namespace jaruernCore.Models
{
    public class mdlStockCard
    {
        public Guid Id { get; set; }
        public DateTime Atdate { get; set; }
        public string AtdateStr { get; set; }
        public string Cardno { get; set; }
        public int Goods { get; set; }
        public int Piece { get; set; }
        public string Remark { get; set; }
        public string Ownername { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
