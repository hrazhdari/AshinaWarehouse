using Microsoft.EntityFrameworkCore;
using AWMS.datalayer.Entities;
using AWMS.datalayer.Factories;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using AWMS.datalayer.Entities.Configurations;

namespace AWMS.datalayer.Context
{
    public class AWMScontext : DbContext
    {
        #region DbSet
        public DbSet<Mr> Mrs { get; set; }
        public DbSet<Po> Pos { get; set; }
        public DbSet<PackingList> PackingLists { get; set; }
        public DbSet<Irn> Irns { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Descipline> Desciplines { get; set; }
        public DbSet<DescriptionForPk> DescriptionForPks { get; set; }
        public DbSet<AreaUnit> AreaUnits { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitPrice> UnitPrices { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyContract> CompanyContracts { get; set; }
        #endregion

        public AWMScontext(DbContextOptions<AWMScontext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API Configuration's
            modelBuilder.ApplyConfiguration(new MrConfiguration());
            modelBuilder.ApplyConfiguration(new PoConfiguration());
            modelBuilder.ApplyConfiguration(new PackingListConfiguration());
            modelBuilder.ApplyConfiguration(new ShipmentConfiguration());
            modelBuilder.ApplyConfiguration(new VendorConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new IrnConfiguration());
            modelBuilder.ApplyConfiguration(new DescriptionForPkConfiguration());
            modelBuilder.ApplyConfiguration(new DesciplineConfiguration());
            modelBuilder.ApplyConfiguration(new AreaUnitConfiguration());
            modelBuilder.ApplyConfiguration(new PackageConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new UnitPriceConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new ScopeConfiguration());

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
            modelBuilder.Entity<AreaUnit>().HasData(
                new AreaUnit { AreaUnitID = 1, AreaUnitName = "-", AreaUnitDescription = "-", AreaUnitTrain = "-" }
            );
            modelBuilder.Entity<Vendor>().HasData(
                new Vendor { VendorID = 1, VendorName = "-", VendorContractDescription = "-", VendorAbbreviation = "-", VendorContractNO = "-" }
            );
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, SupplierName = "-", SupplierRemark = "-" }
            );
            modelBuilder.Entity<Shipment>().HasData(
                new Shipment { ShipmentId=1,ShipmentName="-",ShipmentDescription="-",PoId=1}
            );
            modelBuilder.Entity<Irn>().HasData(
                new Irn { IrnId=1,IrnName="-",IrnDescription="-" }
            );
            modelBuilder.Entity<DescriptionForPk>().HasData(
                new DescriptionForPk {DescriptionForPkId=1,Description="-" }
            );
            modelBuilder.Entity<Descipline>().HasData(
                new Descipline { DesciplineId=1,DesciplineName="Piping"},
                new Descipline { DesciplineId=2,DesciplineName="Support"},
                new Descipline { DesciplineId=3,DesciplineName="Mechanical"},
                new Descipline { DesciplineId=4,DesciplineName="Electrical"},
                new Descipline { DesciplineId=5,DesciplineName="Instrument"},
                new Descipline { DesciplineId=6,DesciplineName="Civil"},
                new Descipline { DesciplineId=7,DesciplineName="Steel Structure"},
                new Descipline { DesciplineId=8,DesciplineName="Steel Profile"},
                new Descipline { DesciplineId=9,DesciplineName="Paint"},
                new Descipline { DesciplineId=10,DesciplineName="Insulation"},
                new Descipline { DesciplineId=11,DesciplineName="Other"}
            );
        }
    }
}
