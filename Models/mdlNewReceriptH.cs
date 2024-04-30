namespace jaruernCore.Models
{
    public class mdlNewReceriptH
    {
        public string Culture { get; set; }
        public string Atdate { get; set; }
        public Guid Storeid { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Discount { get; set; }
        public string Remark { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? TaxRate { get; set; }

        public int CashType { get; set; }
        public decimal? CusCash { get; set; }
        public decimal? CusChange { get; set; }
        public string CreditNo { get; set; }
        public decimal? CusCredit{ get; set; }
        public decimal? Fullprice { get; set; }
        public decimal? Deposit { get; set; }

        public string MemberId { get; set; }

        public string TypeCode { get; set; }

        public string RefId { get; set; }

        public List<mdlNewReceript> NewReceripts { get; set; }
    }
}
