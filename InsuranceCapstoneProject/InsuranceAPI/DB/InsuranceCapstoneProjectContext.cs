using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace InsuranceAPI.DB;

public partial class InsuranceCapstoneProjectContext : DbContext
{
    public InsuranceCapstoneProjectContext()
    {
    }

    public InsuranceCapstoneProjectContext(DbContextOptions<InsuranceCapstoneProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminsInfo> AdminsInfos { get; set; }

    public virtual DbSet<InsuranceDetail> InsuranceDetails { get; set; }

    public virtual DbSet<UsersInfo> UsersInfos { get; set; }

    //Search By Name
    public List<InsuranceDetail> SearchInsuranceByName(string name)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByName";
        sql += " @insuranceBrand";
        parameters.Add(new SqlParameter("@insuranceBrand", (object)name ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }

    //Search By Category
    public List<InsuranceDetail> SearchInsuranceByCategory(string category)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByCategory";
        sql += " @insuranceCategory";
        parameters.Add(new SqlParameter("@insuranceCategory", (object)category ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }
    //Search By Price Range
    public List<InsuranceDetail> SearchInsuranceByPriceRange(double p1, double p2)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByPriceRange";
        sql += " @minPrice,";
        parameters.Add(new SqlParameter("@minPrice", (object)p1 ?? DBNull.Value));
        sql += " @maxPrice";
        parameters.Add(new SqlParameter("@maxPrice", (object)p2 ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }
    //Search By Max Price
    public List<InsuranceDetail> SearchInsuranceByMaxPrice(double p1)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByMaxPrice";
       
        sql += " @maxPrice";
        parameters.Add(new SqlParameter("@maxPrice", (object)p1 ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }
    //Search By Min Price
    public List<InsuranceDetail> SearchInsuranceByMinPrice(double p2)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByMinPrice";

        sql += " @maxPrice";
        parameters.Add(new SqlParameter("@minPrice", (object)p2 ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }
    //Search By Age Range
    public List<InsuranceDetail> SearchInsuranceByAge(int a1, int a2)
    {
        var parameters = new List<object>();
        var sql = "EXEC SearchInsuranceByAgeRange";

        sql += " @age1, @age2";
        parameters.Add(new SqlParameter("@age1", (object)a1 ?? DBNull.Value));
        parameters.Add(new SqlParameter("@age2", (object)a2 ?? DBNull.Value));
        return this.InsuranceDetails.FromSqlRaw(sql, parameters.ToArray()).ToList();
    }

    //add new insurance
    public void AddInsuranceDetail(string insuranceBrand, string insuranceCategory, string insuranceDescription, decimal insurancePrice, int insuranceAgeRequirement)
    {
        var parameters = new List<object>();
        var sql = "EXEC AddInsuranceDetail";

        sql += " @insuranceBrand, @insuranceCategory, @insuranceDescription, @insurancePrice, @insuranceAgeRequirement";
        parameters.Add(new SqlParameter("@insuranceBrand", (object)insuranceBrand ?? DBNull.Value));
        parameters.Add(new SqlParameter("@insuranceCategory", (object)insuranceCategory ?? DBNull.Value));
        parameters.Add(new SqlParameter("@insuranceDescription", (object)insuranceDescription ?? DBNull.Value));
        parameters.Add(new SqlParameter("@insurancePrice", (object)insurancePrice ?? DBNull.Value));
        parameters.Add(new SqlParameter("@insuranceAgeRequirement", (object)insuranceAgeRequirement ?? DBNull.Value));

       this.Database.ExecuteSqlRaw(sql, parameters.ToArray());
    }

    //delete insurance
    public void DeleteInsuranceDetail(int insuranceID)
    {
        var parameters = new List<object>();
        var sql = "EXEC DeleteInsuranceDetail @insuranceID";
        parameters.Add(new SqlParameter("@insuranceID", (object)insuranceID ?? DBNull.Value));

        this.Database.ExecuteSqlRaw(sql, parameters.ToArray());
    }









    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=8790060CC7795EB;database=InsuranceCapstoneProject;integrated security = true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminsInfo>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__AdminsIn__719FE4E8C0961DD4");

            entity.ToTable("AdminsInfo");

            entity.HasIndex(e => e.Username, "UQ__AdminsIn__536C85E46FCD5772").IsUnique();

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<InsuranceDetail>(entity =>
        {
            entity.HasKey(e => e.InsuranceId).HasName("PK__Insuranc__79D82EF0B8A61533");

            entity.Property(e => e.InsuranceId).HasColumnName("insuranceID");
            entity.Property(e => e.InsuranceAgeRequirement).HasColumnName("insuranceAgeRequirement");
            entity.Property(e => e.InsuranceBrand)
                .HasMaxLength(100)
                .HasColumnName("insuranceBrand");
            entity.Property(e => e.InsuranceCategory)
                .HasMaxLength(20)
                .HasColumnName("insuranceCategory");
            entity.Property(e => e.InsuranceDescription).HasColumnName("insuranceDescription");
            entity.Property(e => e.InsurancePrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("insurancePrice");
        });

        modelBuilder.Entity<UsersInfo>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UsersInf__CB9A1CDF4FA47C23");

            entity.ToTable("UsersInfo");

            entity.HasIndex(e => e.UserName, "UQ__UsersInf__66DCF95C5F8EDA34").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .HasColumnName("mobileNumber");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasColumnName("userEmail");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .HasColumnName("userPassword");
            entity.Property(e => e.WalletBalance)
                .HasColumnType("decimal(20, 2)")
                .HasColumnName("walletBalance");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
