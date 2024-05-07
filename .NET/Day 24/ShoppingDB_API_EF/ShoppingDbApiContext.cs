using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShoppingDB_API_EF;

public partial class ShoppingDbApiContext : DbContext
{
    public ShoppingDbApiContext()
    {
    }

    public ShoppingDbApiContext(DbContextOptions<ShoppingDbApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customerdetail> Customerdetails { get; set; }

    public virtual DbSet<Orderdetail> Orderdetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=8790060CC7795EB;database=ShoppingDB_API;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customerdetail>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__customer__D830D457D4455BB8");

            entity.ToTable("customerdetails");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cID");
            entity.Property(e => e.CCity)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cCity");
            entity.Property(e => e.CEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cEmail");
            entity.Property(e => e.CName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CWalletBalance)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<Orderdetail>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__orderdet__C2FECB1B519142B7");

            entity.ToTable("orderdetails");

            entity.Property(e => e.OId)
                .ValueGeneratedNever()
                .HasColumnName("oID");
            entity.Property(e => e.CId).HasColumnName("cID");
            entity.Property(e => e.OProductId).HasColumnName("oProductID");
            entity.Property(e => e.OrderTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("orderTotal");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.Orderdetails)
                .HasForeignKey(d => d.CId)
                .HasConstraintName("FK__orderdetail__cID__3E52440B");

            entity.HasOne(d => d.OProduct).WithMany(p => p.Orderdetails)
                .HasForeignKey(d => d.OProductId)
                .HasConstraintName("FK__orderdeta__oProd__3D5E1FD2");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__products__DD36D502991881F1");

            entity.ToTable("products");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pID");
            entity.Property(e => e.PAvailableQty).HasColumnName("pAvailableQty");
            entity.Property(e => e.PDiscountPercentage)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("pDiscountPercentage");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.POfferCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pOfferCode");
            entity.Property(e => e.POfferCodePercentage)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("pOfferCodePercentage");
            entity.Property(e => e.PPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
