using jaruernCore.Models.dbs_jaruern_inv;
using System.Globalization;

namespace jaruernCore.localLib
{
    public class serviceStock
    {
        private Guid StoreId;

        public serviceStock(Guid storeId)
        {
            StoreId = storeId;
        }

        public string newCardNo(DateTime atdate,string Culture)
        {
            CultureInfo culture = new CultureInfo("en-US");
            if(Culture.ToLower()=="th")
                culture = new CultureInfo("th-TH");

            string res = "";
            string typename = "SKI";
            string keycode = typename + atdate.ToString("yyMM", culture);

            int runn_no = new serviceJCore().GetRunning(StoreId, typename, keycode);

            res = keycode + runn_no.ToString("00000");

            return res;
        }
    }
}
