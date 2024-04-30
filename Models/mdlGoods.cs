using jaruernCore.Models.dbs_jaruern_inv;

namespace jaruernCore.Models
{
    public class mdlGoods : Good
    {
        public string Producttypename { get; set; }
        public string Productgroupname { get; set; }
        public bool Favorite { get; set; }
    }
}
