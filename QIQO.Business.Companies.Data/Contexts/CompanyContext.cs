using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Entities;

namespace QIQO.Business.Companies.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<CompanyData> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressData>().ToTable("Address");
            modelBuilder.Entity<AddressTypeData>().ToTable("AddressType");
            modelBuilder.Entity<AttributeTypeData>().ToTable("AttributeType");
            modelBuilder.Entity<ChartOfAccountData>().ToTable("ChartOfAccount");
            modelBuilder.Entity<CompanyData>().ToTable("Company");
            modelBuilder.Entity<EmployeeData>().ToTable("Employee");
            modelBuilder.Entity<EmployeeTypeData>().ToTable("EmployeeType");
            modelBuilder.Entity<EntityAttributeData>().ToTable("EntityAttribute");
            modelBuilder.Entity<EntityTypeData>().ToTable("EntityType");
            modelBuilder.Entity<FeeScheduleData>().ToTable("FeeSchedule");
            modelBuilder.Entity<LedgerData>().ToTable("Ledger");
            modelBuilder.Entity<LedgerTxnData>().ToTable("LedgerTxn");
            modelBuilder.Entity<ProductData>().ToTable("Product");
            modelBuilder.Entity<ProductTypeData>().ToTable("ProductType");

            modelBuilder.Entity<CompanyData>().HasAlternateKey(p => p.CompanyCode);
            modelBuilder.Entity<CompanyData>().HasMany(a => a.CompanyAddresses).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CompanyData>().HasMany(a => a.CompanyAttributes).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CompanyData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<CompanyData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<CompanyData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<CompanyData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<EmployeeData>().HasAlternateKey(p => p.EmployeeCode);
            modelBuilder.Entity<EmployeeData>().HasMany(a => a.EmployeeAddresses).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeData>().HasMany(a => a.EmployeeAttributes).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EmployeeData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EmployeeData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<EmployeeData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<ProductData>().HasAlternateKey(p => p.ProductCode);
            modelBuilder.Entity<ProductData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ProductData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ProductData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<ProductData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");
            
            modelBuilder.Entity<AddressData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<AddressData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<AddressData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<AddressData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<ChartOfAccountData>().HasAlternateKey(p => p.AccountNo);
            modelBuilder.Entity<ChartOfAccountData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ChartOfAccountData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ChartOfAccountData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<ChartOfAccountData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<EntityAttributeData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EntityAttributeData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EntityAttributeData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<EntityAttributeData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<FeeScheduleData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<FeeScheduleData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<FeeScheduleData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<FeeScheduleData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<LedgerData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<LedgerData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<LedgerTxnData>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerTxnData>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerTxnData>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<LedgerTxnData>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");
        }
    }
}
