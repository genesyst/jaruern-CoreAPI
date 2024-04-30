using Microsoft.EntityFrameworkCore;

namespace jaruernCore.Models.dbs_jaruern_inv
{
    public partial class JaruernInvContext
    {
        public virtual DbSet<spSTKLastPrice> spSTKLastPrice { get; set; }
        public virtual DbSet<spGoodsForSale> spGoodsForSale { get; set; }
        public virtual DbSet<spGoodsInStock> spGoodsInStock { get; set; }
        public virtual DbSet<spStockBal> spStockBal { get; set; }
        public virtual DbSet<spSale> spSale { get; set; }
    }
}
