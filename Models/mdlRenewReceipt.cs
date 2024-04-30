using Genesyst.Models;

namespace jaruernCore.Models
{
    public class mdlRenewReceipt
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string Culture { get; set; }
        public string RefundType { get; set; }
        public string Remark { get; set; }
        public List<mdlRenewReceiptGoods> XGoodsReason { get; set; }
    }
}
