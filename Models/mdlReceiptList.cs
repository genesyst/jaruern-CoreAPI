using jaruernCore.Models.dbs_jmmdatacenter;

namespace jaruernCore.Models
{
    public class mdlReceiptList
    {
        public Guid Id { get; set; }
        public string ReceiptNo { get; set; }
        public int? Piece { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Dis { get; set; }
        public bool isRefund { get; set; }
    }
}
