namespace jaruernCore.Models
{
    public class mdlStockBalance
    {
        public Guid GoodsId { get; set; }
        public string GoodsName { get; set; }

        public int TBFPiece { get; set; }
        public decimal TBFcost { get; set; }

        public int InPiece { get; set; }
        public decimal Incost { get; set; }

        public int OutPiece { get; set; }
        public decimal Outcost { get; set; }

        public int TCFPiece { get; set; }
        public decimal TCFcost { get; set; }
    }
}
