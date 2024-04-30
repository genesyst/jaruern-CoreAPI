using jaruernCore.Models.dbs_jaruern_inv;
using System.Globalization;

namespace jaruernCore.localLib
{
    public class serviceSale
    {
        private Guid StoreId;

        public serviceSale(Guid storeId)
        {
            StoreId = storeId;
        }

        public string newReceiptNo(DateTime atdate,string typeCode, string Culture)
        {
            CultureInfo culture = new CultureInfo("en-US");
            if (Culture.ToLower() == "th")
                culture = new CultureInfo("th-TH");

            string res = "";
            //string typename = "RPT";
            string keycode = typeCode + atdate.ToString("yyMMdd", culture);

            int runn_no = new serviceJCore().GetRunning(StoreId, typeCode, keycode);

            res = keycode+runn_no.ToString("00000");

            return res;
        }
    }
}
