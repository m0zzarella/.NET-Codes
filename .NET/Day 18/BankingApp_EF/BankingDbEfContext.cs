using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankingApp_EF;

public partial class BankingDbEfContext : DbContext
{
    public BankingDbEfContext()
    {
    }

    public BankingDbEfContext(DbContextOptions<BankingDbEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountsInfo> AccountsInfos { get; set; }

    public virtual DbSet<BranchInfo> BranchInfos { get; set; }

    public virtual DbSet<TransactionInfo> TransactionInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=8790060CC7795EB;database=BankingDB_EF;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountsInfo>(entity =>
        {
            entity.HasKey(e => e.AccNo).HasName("PK__Accounts__A4719705FB300B60");

            entity.ToTable("AccountsInfo");

            entity.Property(e => e.AccNo)
                .ValueGeneratedNever()
                .HasColumnName("accNo");
            entity.Property(e => e.AccBalance).HasColumnName("accBalance");
            entity.Property(e => e.AccBranch).HasColumnName("accBranch");
            entity.Property(e => e.AccIsActive).HasColumnName("accIsActive");
            entity.Property(e => e.AccName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accName");
            entity.Property(e => e.AccType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accType");

            entity.HasOne(d => d.AccBranchNavigation).WithMany(p => p.AccountsInfos)
                .HasForeignKey(d => d.AccBranch)
                .HasConstraintName("FK__AccountsI__accBr__398D8EEE");
        });

        modelBuilder.Entity<BranchInfo>(entity =>
        {
            entity.HasKey(e => e.BranchNo).HasName("PK__BranchIn__751EC4A004A8C6F4");

            entity.ToTable("BranchInfo");

            entity.Property(e => e.BranchNo)
                .ValueGeneratedNever()
                .HasColumnName("branchNo");
            entity.Property(e => e.BranchEmail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("branchEmail");
            entity.Property(e => e.BranchLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("branchLocation");
            entity.Property(e => e.BranchName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("branchName");
        });

        modelBuilder.Entity<TransactionInfo>(entity =>
        {
            entity.HasKey(e => e.TrNo).HasName("PK__Transact__9C31CC295D42630B");

            entity.ToTable("TransactionInfo");

            entity.Property(e => e.TrNo).HasColumnName("trNo");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Datetime1)
                .HasColumnType("datetime")
                .HasColumnName("datetime1");
            entity.Property(e => e.FromAccNo).HasColumnName("fromAccNo");

            entity.HasOne(d => d.FromAccNoNavigation).WithMany(p => p.TransactionInfoFromAccNoNavigations)
                .HasForeignKey(d => d.FromAccNo)
                .HasConstraintName("FK__Transacti__fromA__3C69FB99");

            entity.HasOne(d => d.ToAccNoNavigation).WithMany(p => p.TransactionInfoToAccNoNavigations)
                .HasForeignKey(d => d.ToAccNo)
                .HasConstraintName("FK__Transacti__ToAcc__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
