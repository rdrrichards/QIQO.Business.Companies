using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Entities;

namespace QIQO.Business.Companies.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Company>().HasAlternateKey(p => p.CompanyCode);
            modelBuilder.Entity<Company>().HasMany(a => a.CompanyAddresses).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Company>().HasMany(a => a.CompanyAttributes).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Company>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Company>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Company>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<Company>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<Employee>().HasAlternateKey(p => p.EmployeeCode);
            modelBuilder.Entity<Employee>().HasMany(a => a.EmployeeAddresses).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Employee>().HasMany(a => a.EmployeeAttributes).WithOne().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Employee>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Employee>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Employee>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<Employee>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<Product>().HasAlternateKey(p => p.ProductCode);
            modelBuilder.Entity<Product>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Product>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Product>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<Product>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");
            
            modelBuilder.Entity<Address>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Address>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Address>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<Address>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<ChartOfAccount>().HasAlternateKey(p => p.AccountNo);
            modelBuilder.Entity<ChartOfAccount>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ChartOfAccount>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ChartOfAccount>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<ChartOfAccount>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<EntityAttribute>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EntityAttribute>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<EntityAttribute>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<EntityAttribute>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<FeeSchedule>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<FeeSchedule>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<FeeSchedule>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<FeeSchedule>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<Ledger>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Ledger>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Ledger>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<Ledger>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");

            modelBuilder.Entity<LedgerTxn>().Property(p => p.AddedDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerTxn>().Property(p => p.UpdateDateTime).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LedgerTxn>().Property(p => p.AddedUserID).HasDefaultValueSql("SUSER_NAME()");
            modelBuilder.Entity<LedgerTxn>().Property(p => p.UpdateUserID).HasDefaultValueSql("SUSER_NAME()");
        }
    }
}
