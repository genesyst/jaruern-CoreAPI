using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jaruernCore.Models.dbs_jaruern_inv;

public partial class JaruernInvContext : DbContext
{
    public JaruernInvContext()
    {
    }

    public JaruernInvContext(DbContextOptions<JaruernInvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodsFavorite> GoodsFavorites { get; set; }

    public virtual DbSet<GoodsImg> GoodsImgs { get; set; }

    public virtual DbSet<Goodsreturntype> Goodsreturntypes { get; set; }

    public virtual DbSet<Productgroup> Productgroups { get; set; }

    public virtual DbSet<Producttype> Producttypes { get; set; }

    public virtual DbSet<ReceiptH> ReceiptHs { get; set; }

    public virtual DbSet<ReceiptX> ReceiptXes { get; set; }

    public virtual DbSet<Recript> Recripts { get; set; }

    public virtual DbSet<RecriptCuscash> RecriptCuscashes { get; set; }

    public virtual DbSet<Refundtype> Refundtypes { get; set; }

    public virtual DbSet<Running> Runnings { get; set; }

    public virtual DbSet<Sett> Setts { get; set; }

    public virtual DbSet<StkCard> StkCards { get; set; }

    public virtual DbSet<StkGood> StkGoods { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<ViewStkgood> ViewStkgoods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=103.76.180.20\\SQL2017EXPRESS;Initial Catalog=JARUERN_INV;User ID=sa;Password=sqlampwd@2020;Encrypt=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Good>(entity =>
        {
            entity.ToTable("GOODS");

            entity.HasIndex(e => e.Active, "IX_GOODS_ACTIVE");

            entity.HasIndex(e => e.Skubarcode, "IX_GOODS_SKUBARCODE");

            entity.HasIndex(e => e.Skucode, "IX_GOODS_SKUCODE");

            entity.HasIndex(e => e.Stt, "IX_GOODS_STT");

            entity.HasIndex(e => e.Teamid, "IX_GOODS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp).HasColumnName("DESP");
            entity.Property(e => e.Productgroupid).HasColumnName("PRODUCTGROUPID");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Producttypeid).HasColumnName("PRODUCTTYPEID");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(50)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplayname)
                .HasMaxLength(200)
                .HasColumnName("SKUDISPLAYNAME");
            entity.Property(e => e.Skuname)
                .HasMaxLength(200)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(200)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Skusize)
                .HasMaxLength(200)
                .HasColumnName("SKUSIZE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag).HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<GoodsFavorite>(entity =>
        {
            entity.ToTable("GOODS_FAVORITE");

            entity.HasIndex(e => e.Goodsid, "IX_GOODS_FAVORITE_GOODSID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Goodsid).HasColumnName("GOODSID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<GoodsImg>(entity =>
        {
            entity.ToTable("GOODS_IMG");

            entity.HasIndex(e => e.Barcode, "IX_GOODS_IMG_BARCODE");

            entity.HasIndex(e => e.CreateBy, "IX_GOODS_IMG_CREATE_BY");

            entity.HasIndex(e => e.Stt, "IX_GOODS_IMG_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasColumnName("BARCODE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Imgtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IMGTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag).HasColumnName("TAG");
        });

        modelBuilder.Entity<Goodsreturntype>(entity =>
        {
            entity.ToTable("GOODSRETURNTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Productgroup>(entity =>
        {
            entity.ToTable("PRODUCTGROUP");

            entity.HasIndex(e => e.Active, "IX_PRODUCTGROUP_ACTIVE");

            entity.HasIndex(e => e.Productgroupcode, "IX_PRODUCTGROUP_PRODUCTGROUPCODE");

            entity.HasIndex(e => e.Producttypeid, "IX_PRODUCTGROUP_PRODUCTTYPEID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Productgroupcode)
                .HasMaxLength(10)
                .HasColumnName("PRODUCTGROUPCODE");
            entity.Property(e => e.Productgroupname)
                .HasMaxLength(100)
                .HasColumnName("PRODUCTGROUPNAME");
            entity.Property(e => e.Producttypeid).HasColumnName("PRODUCTTYPEID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Producttype>(entity =>
        {
            entity.ToTable("PRODUCTTYPE");

            entity.HasIndex(e => e.Active, "IX_PRODUCTTYPE_ACTIVE");

            entity.HasIndex(e => e.Producttypecode, "IX_PRODUCTTYPE_PRODUCTTYPECODE");

            entity.HasIndex(e => e.Stt, "IX_PRODUCTTYPE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Producttypecode)
                .HasMaxLength(10)
                .HasColumnName("PRODUCTTYPECODE");
            entity.Property(e => e.Producttypename)
                .HasMaxLength(100)
                .HasColumnName("PRODUCTTYPENAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ReceiptH>(entity =>
        {
            entity.ToTable("RECEIPT_H");

            entity.HasIndex(e => e.Atdate, "IX_RECEIPT_H_ATDATE");

            entity.HasIndex(e => e.Receiptno, "IX_RECEIPT_H_RECEIPTNO");

            entity.HasIndex(e => e.Storeid, "IX_RECEIPT_H_STOREID");

            entity.HasIndex(e => e.Stt, "IX_RECEIPT_H_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Deposit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEPOSIT");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Fullprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FULLPRICE");
            entity.Property(e => e.Memberid)
                .HasMaxLength(50)
                .HasColumnName("MEMBERID");
            entity.Property(e => e.ReReceiptid).HasColumnName("RE_RECEIPTID");
            entity.Property(e => e.ReReftype)
                .HasMaxLength(10)
                .HasColumnName("RE_REFTYPE");
            entity.Property(e => e.ReRefund)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RE_REFUND");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(30)
                .HasColumnName("RECEIPTNO");
            entity.Property(e => e.RefId).HasColumnName("REF_ID");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag).HasColumnName("TAG");
            entity.Property(e => e.Taxrate)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("TAXRATE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAT");
            entity.Property(e => e.Vatrate)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("VATRATE");
        });

        modelBuilder.Entity<ReceiptX>(entity =>
        {
            entity.ToTable("RECEIPT_X");

            entity.HasIndex(e => e.Receiptid, "IX_RECEIPT_X_RECEIPTID");

            entity.HasIndex(e => e.Stt, "IX_RECEIPT_X_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Reasonno)
                .HasMaxLength(2)
                .HasColumnName("REASONNO");
            entity.Property(e => e.Reasontxt)
                .HasMaxLength(100)
                .HasColumnName("REASONTXT");
            entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<Recript>(entity =>
        {
            entity.ToTable("RECRIPT");

            entity.HasIndex(e => e.Active, "IX_RECRIPT_ACTIVE");

            entity.HasIndex(e => e.Cashtype, "IX_RECRIPT_CASHTYPE");

            entity.HasIndex(e => e.Goodsid, "IX_RECRIPT_GOODSID");

            entity.HasIndex(e => e.Recriptid, "IX_RECRIPT_RECRIPTID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.Cashtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CASHTYPE");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Goodsid).HasColumnName("GOODSID");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.ReCode)
                .HasMaxLength(10)
                .HasColumnName("RE_CODE");
            entity.Property(e => e.ReReason)
                .HasMaxLength(100)
                .HasColumnName("RE_REASON");
            entity.Property(e => e.Recriptid).HasColumnName("RECRIPTID");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Saleprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALEPRICE");
            entity.Property(e => e.Tag).HasColumnName("TAG");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<RecriptCuscash>(entity =>
        {
            entity.ToTable("RECRIPT_CUSCASH");

            entity.HasIndex(e => e.Cashtype, "IX_RECRIPT_CUSCASH_CASHTYPE");

            entity.HasIndex(e => e.Recriptid, "IX_RECRIPT_CUSCASH_RECRIPTID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cashtype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CASHTYPE");
            entity.Property(e => e.Creditno)
                .HasMaxLength(30)
                .HasColumnName("CREDITNO");
            entity.Property(e => e.Cuscash)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUSCASH");
            entity.Property(e => e.Cuscashchang)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUSCASHCHANG");
            entity.Property(e => e.Cuscredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUSCREDIT");
            entity.Property(e => e.Recriptid).HasColumnName("RECRIPTID");
        });

        modelBuilder.Entity<Refundtype>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("REFUNDTYPE");

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODE");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Seq)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("SEQ");
        });

        modelBuilder.Entity<Running>(entity =>
        {
            entity.ToTable("RUNNING");

            entity.HasIndex(e => e.Storeid, "IX_RUNNING_STOREID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Keycode)
                .HasMaxLength(50)
                .HasColumnName("KEYCODE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Typename)
                .HasMaxLength(20)
                .HasColumnName("TYPENAME");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<Sett>(entity =>
        {
            entity.ToTable("SETT");

            entity.HasIndex(e => e.Setkey, "IX_SETT_SETKEY");

            entity.HasIndex(e => e.Storeid, "IX_SETT_STOREID");

            entity.HasIndex(e => e.Stt, "IX_SETT_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Setkey)
                .HasMaxLength(20)
                .HasColumnName("SETKEY");
            entity.Property(e => e.SetvalDou)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SETVAL_DOU");
            entity.Property(e => e.SetvalInt).HasColumnName("SETVAL_INT");
            entity.Property(e => e.SetvalStr)
                .HasMaxLength(100)
                .HasColumnName("SETVAL_STR");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StkCard>(entity =>
        {
            entity.ToTable("STK_CARD");

            entity.HasIndex(e => e.Cardno, "IX_STK_CARD_CARDNO");

            entity.HasIndex(e => e.Storeid, "IX_STK_CARD_STOREID");

            entity.HasIndex(e => e.Stt, "IX_STK_CARD_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cardno)
                .HasMaxLength(30)
                .HasColumnName("CARDNO");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag).HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StkGood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GOODSPRICES");

            entity.ToTable("STK_GOODS");

            entity.HasIndex(e => e.Active, "IX_GOODSPRICES_ACTIVE");

            entity.HasIndex(e => e.Goodid, "IX_GOODSPRICES_GOODID");

            entity.HasIndex(e => e.Cardid, "IX_STK_GOODS_CARDID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Cardid).HasColumnName("CARDID");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COST");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Goodid).HasColumnName("GOODID");
            entity.Property(e => e.Memberprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MEMBERPRICE");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Saleprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALEPRICE");
            entity.Property(e => e.Tag).HasColumnName("TAG");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("UNIT");

            entity.HasIndex(e => e.Active, "IX_UNIT_ACTIVE");

            entity.HasIndex(e => e.Seq, "IX_UNIT_SEQ");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Uniten)
                .HasMaxLength(30)
                .HasColumnName("UNITEN");
            entity.Property(e => e.Unitth)
                .HasMaxLength(30)
                .HasColumnName("UNITTH");
        });

        modelBuilder.Entity<ViewStkgood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STKGOODS");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cardno)
                .HasMaxLength(30)
                .HasColumnName("CARDNO");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COST");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Goodid).HasColumnName("GOODID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Memberprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MEMBERPRICE");
            entity.Property(e => e.Piece).HasColumnName("PIECE");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Saleprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALEPRICE");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(50)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(200)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(200)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Skusize)
                .HasMaxLength(200)
                .HasColumnName("SKUSIZE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Uniten)
                .HasMaxLength(30)
                .HasColumnName("UNITEN");
            entity.Property(e => e.Unitth)
                .HasMaxLength(30)
                .HasColumnName("UNITTH");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
