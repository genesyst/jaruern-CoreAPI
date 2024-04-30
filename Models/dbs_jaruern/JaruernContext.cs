using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jaruernCore.Models.dbs_jaruern;

public partial class JaruernContext : DbContext
{
    public JaruernContext()
    {
    }

    public JaruernContext(DbContextOptions<JaruernContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accesslevel> Accesslevels { get; set; }

    public virtual DbSet<TckAccess> TckAccesses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=103.76.180.20\\SQL2017EXPRESS;Initial Catalog=JARUERN;User ID=sa;Password=sqlampwd@2020;Encrypt=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accesslevel>(entity =>
        {
            entity.HasKey(e => e.Accesstype);

            entity.ToTable("ACCESSLEVEL");

            entity.Property(e => e.Accesstype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACCESSTYPE");
            entity.Property(e => e.Accessname)
                .HasMaxLength(100)
                .HasColumnName("ACCESSNAME");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
        });

        modelBuilder.Entity<TckAccess>(entity =>
        {
            entity.ToTable("TCK_ACCESS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .HasColumnName("TOKEN");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Usercode)
                .HasMaxLength(50)
                .HasColumnName("USERCODE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USERS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Activate)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Empcode)
                .HasMaxLength(20)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Secretcode)
                .HasMaxLength(100)
                .HasColumnName("SECRETCODE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
