using Microsoft.EntityFrameworkCore;
using AWMS.datalayer.Entities;
using AWMS.datalayer.Factories;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;

namespace AWMS.datalayer.Context
{
    public class AWMScontext : DbContext
    {
        public DbSet<Mr> Mrs { get; set; }
        public DbSet<Po> Pos { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyContract> CompanyContracts { get; set; }

        public AWMScontext(DbContextOptions<AWMScontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Mr>().HasData(
                new Mr { MrId = 1, MrName = "-" }
            );
            modelBuilder.Entity<Po>().HasData(
                new Po { PoId = 1, MrId = 1, PoName = "-" }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyID = 1, CompanyName = "Petro Paydar Iranian", Abbreviation = "PPI" },
                new Company { CompanyID = 2, CompanyName = "Teco", Abbreviation = "TESCO" }
            );
        }
    }
}
