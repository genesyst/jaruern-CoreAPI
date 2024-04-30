namespace jaruernCore.Models
{
    public class mdlReceipt
    {
        public Guid Id { get; set; }
        public string ReceiptNo {  get; set; }
        public string Atdate { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }
        public Guid Storeid { get; set; }
        public string StoreName { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Discount { get; set; }
        public string Remark { get; set; }
        public string VatNo { get; set; }
        public decimal? VatRate { get; set; }
        public string TaxNo { get; set; }
        public decimal? TaxRate { get; set; }

        public string CashType { get; set; }
        public decimal? CusCash { get; set; }
        public decimal? CusChange { get; set; }
        public string CreditNo { get; set; }
        public decimal? CusCredit { get; set; }
        public decimal? Fullprice { get; set; }
        public decimal? Deposit { get; set; }

        public string MemberId { get; set; }

        public List<mdlReceriptGoods> ReceriptGoods { get; set; }

        public string XReceiptNo { get; set; }
        public decimal? XReceiptCash{ get; set; }
        public decimal? Refund { get; set; }
        public string RefundType { get; set; }

        public Guid? RefId { get; set; }

        public List<mdlReceriptGoods> XReceriptGoods { get; set; }
    }
}
