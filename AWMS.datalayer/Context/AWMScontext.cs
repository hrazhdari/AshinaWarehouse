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
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyContract> CompanyContracts { get; set; }
        
        public AWMScontext(DbContextOptions<AWMScontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyID = 1, CompanyName = "Petro Paydar Iranian", Abbreviation = "PPI" },
                new Company { CompanyID = 2, CompanyName = "MAPNA", Abbreviation = "MAPNA" }
            );

            //modelBuilder.Entity<Member>().HasData(
            //    new Member { Id = 1, Name = "Member 1", Email = "member1@example.com" },
            //    new Member { Id = 2, Name = "Member 2", Email = "member2@example.com" }
            //);

        }
    }
}
