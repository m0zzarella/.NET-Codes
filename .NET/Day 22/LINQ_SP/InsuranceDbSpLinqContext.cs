using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LINQ_SP;

public partial class InsuranceDbSpLinqContext : DbContext
{
    public InsuranceDbSpLinqContext()
    {
    }

    public InsuranceDbSpLinqContext(DbContextOptions<InsuranceDbSpLinqContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PolicyDetail> PolicyDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=8790060CC7795EB;database=insuranceDB_SP_LINQ;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PolicyDetail>(entity =>
        {
            entity.HasKey(e => e.PolicyNo).HasName("PK__policyDe__78E1E822F3CC431C");

            entity.ToTable("policyDetails");

            entity.Property(e => e.PolicyNo)
                .ValueGeneratedNever()
                .HasColumnName("policyNo");
            entity.Property(e => e.PolicyName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("policyName");
            entity.Property(e => e.PolicyPremium).HasColumnName("policyPremium");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
