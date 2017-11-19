using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIQO.Business.Companies.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
        }
    }
}
