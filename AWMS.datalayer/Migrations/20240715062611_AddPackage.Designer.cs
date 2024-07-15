﻿// <auto-generated />
using System;
using AWMS.datalayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    [DbContext(typeof(AWMScontext))]
    [Migration("20240715062611_AddPackage")]
    partial class AddPackage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AWMS.datalayer.Entities.AreaUnit", b =>
                {
                    b.Property<int>("AreaUnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaUnitID"));

                    b.Property<string>("AreaUnitDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("AreaUnitName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AreaUnitTrain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AreaUnitID");

                    b.ToTable("AreaUnits");

                    b.HasData(
                        new
                        {
                            AreaUnitID = 1,
                            AreaUnitDescription = "-",
                            AreaUnitName = "-",
                            AreaUnitTrain = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"));

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Local_Foreign")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyID = 1,
                            Abbreviation = "PPI",
                            CompanyName = "Petro Paydar Iranian",
                            EnteredDate = new DateTime(2024, 7, 15, 10, 56, 11, 572, DateTimeKind.Local).AddTicks(9736)
                        },
                        new
                        {
                            CompanyID = 2,
                            Abbreviation = "TESCO",
                            CompanyName = "Teco",
                            EnteredDate = new DateTime(2024, 7, 15, 10, 56, 11, 572, DateTimeKind.Local).AddTicks(9789)
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.CompanyContract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"));

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ContractDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContractId");

                    b.HasIndex("CompanyID");

                    b.ToTable("CompanyContracts");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Descipline", b =>
                {
                    b.Property<int>("DesciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesciplineId"));

                    b.Property<string>("DesciplineName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DesciplineId");

                    b.ToTable("Desciplines");

                    b.HasData(
                        new
                        {
                            DesciplineId = 1,
                            DesciplineName = "Piping"
                        },
                        new
                        {
                            DesciplineId = 2,
                            DesciplineName = "Support"
                        },
                        new
                        {
                            DesciplineId = 3,
                            DesciplineName = "Mechanical"
                        },
                        new
                        {
                            DesciplineId = 4,
                            DesciplineName = "Electrical"
                        },
                        new
                        {
                            DesciplineId = 5,
                            DesciplineName = "Instrument"
                        },
                        new
                        {
                            DesciplineId = 6,
                            DesciplineName = "Civil"
                        },
                        new
                        {
                            DesciplineId = 7,
                            DesciplineName = "Steel Structure"
                        },
                        new
                        {
                            DesciplineId = 8,
                            DesciplineName = "Steel Profile"
                        },
                        new
                        {
                            DesciplineId = 9,
                            DesciplineName = "Paint"
                        },
                        new
                        {
                            DesciplineId = 10,
                            DesciplineName = "Insulation"
                        },
                        new
                        {
                            DesciplineId = 11,
                            DesciplineName = "Other"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.DescriptionForPk", b =>
                {
                    b.Property<int>("DescriptionForPkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DescriptionForPkId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("DescriptionForPkId");

                    b.ToTable("DescriptionForPks");

                    b.HasData(
                        new
                        {
                            DescriptionForPkId = 1,
                            Description = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Irn", b =>
                {
                    b.Property<int>("IrnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IrnId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IrnDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IrnName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IrnPdf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IrnId");

                    b.ToTable("Irns");

                    b.HasData(
                        new
                        {
                            IrnId = 1,
                            IrnDescription = "-",
                            IrnName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Mr", b =>
                {
                    b.Property<int>("MrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MrId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MrDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MrName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MrId");

                    b.ToTable("Mrs");

                    b.HasData(
                        new
                        {
                            MrId = 1,
                            MrName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Package", b =>
                {
                    b.Property<int>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PKID"));

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("date");

                    b.Property<string>("Desciption")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Dimension")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("date");

                    b.Property<int?>("EnteredBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("date");

                    b.Property<decimal?>("GrossW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("MSRDate")
                        .HasColumnType("date");

                    b.Property<int?>("MSREnteredBy")
                        .HasColumnType("int");

                    b.Property<string>("MSRNO")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MSRPDF")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("MSRRev")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MSRRevDate")
                        .HasColumnType("date");

                    b.Property<int?>("MSRRevEnteredBy")
                        .HasColumnType("int");

                    b.Property<bool?>("MSRStatus")
                        .HasColumnType("bit");

                    b.Property<decimal?>("NetW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PK")
                        .HasColumnType("int");

                    b.Property<int>("PLId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Volume")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PKID");

                    b.HasIndex("MSRNO")
                        .HasDatabaseName("IX_Package_MSRNO");

                    b.HasIndex("PLId")
                        .HasDatabaseName("IX_Package_PLId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.PackingList", b =>
                {
                    b.Property<int>("PLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PLId"));

                    b.Property<string>("ArchiveNO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AreaUnitID")
                        .HasColumnType("int");

                    b.Property<bool?>("Attachment")
                        .HasColumnType("bit");

                    b.Property<string>("BLNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Balance")
                        .HasColumnType("bit");

                    b.Property<int?>("DesciplineId")
                        .HasColumnType("int");

                    b.Property<int?>("DescriptionForPkId")
                        .HasColumnType("int");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnteredBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("GrossW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IRCNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IrnId")
                        .HasColumnType("int");

                    b.Property<string>("LCNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalForeign")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MARDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MrId")
                        .HasColumnType("int");

                    b.Property<decimal?>("NetW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OPINO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PLDPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLNO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PLName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PoId")
                        .HasColumnType("int");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RTINO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarkcustoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShId")
                        .HasColumnType("int");

                    b.Property<bool?>("SitePL")
                        .HasColumnType("bit");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.Property<string>("Vessel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PLId");

                    b.HasIndex("ArchiveNO")
                        .HasDatabaseName("IX_PackingList_ArchiveNO");

                    b.HasIndex("AreaUnitID")
                        .HasDatabaseName("IX_PackingList_AreaUnitID");

                    b.HasIndex("DesciplineId")
                        .HasDatabaseName("IX_PackingList_DesciplineId");

                    b.HasIndex("DescriptionForPkId")
                        .HasDatabaseName("IX_PackingList_DescriptionForPkId");

                    b.HasIndex("IrnId")
                        .HasDatabaseName("IX_PackingList_IrnId");

                    b.HasIndex("MrId")
                        .HasDatabaseName("IX_PackingList_MrId");

                    b.HasIndex("OPINO")
                        .IsUnique()
                        .HasDatabaseName("IX_PackingList_OPINO")
                        .HasFilter("[OPINO] IS NOT NULL");

                    b.HasIndex("PLNO")
                        .IsUnique()
                        .HasDatabaseName("IX_PackingList_PLNO")
                        .HasFilter("[PLNO] IS NOT NULL");

                    b.HasIndex("PoId")
                        .HasDatabaseName("IX_PackingList_PoId");

                    b.HasIndex("ShId")
                        .HasDatabaseName("IX_PackingList_ShId");

                    b.HasIndex("SupplierId")
                        .HasDatabaseName("IX_PackingList_SupplierId");

                    b.HasIndex("VendorId")
                        .HasDatabaseName("IX_PackingList_VendorId");

                    b.ToTable("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Po", b =>
                {
                    b.Property<int>("PoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MrId")
                        .HasColumnType("int");

                    b.Property<string>("PoDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PoName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("PoId");

                    b.HasIndex("MrId");

                    b.ToTable("Pos");

                    b.HasData(
                        new
                        {
                            PoId = 1,
                            MrId = 1,
                            PoName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipmentId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PoId")
                        .HasColumnType("int");

                    b.Property<string>("ShipmentDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ShipmentName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ShipmentId");

                    b.HasIndex("PoId");

                    b.ToTable("Shipments");

                    b.HasData(
                        new
                        {
                            ShipmentId = 1,
                            PoId = 1,
                            ShipmentDescription = "-",
                            ShipmentName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SupplierRemark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            SupplierName = "-",
                            SupplierRemark = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorID"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Local_Foreign")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorAbbreviation")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("VendorContractDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("VendorContractNO")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("VendorID");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            VendorID = 1,
                            VendorAbbreviation = "-",
                            VendorContractDescription = "-",
                            VendorContractNO = "-",
                            VendorName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.CompanyContract", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Package", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.PackingList", "PackingList")
                        .WithMany("Packages")
                        .HasForeignKey("PLId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PackingList");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.PackingList", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.AreaUnit", "AreaUnit")
                        .WithMany("PackingLists")
                        .HasForeignKey("AreaUnitID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AWMS.datalayer.Entities.Descipline", "Descipline")
                        .WithMany("PackingLists")
                        .HasForeignKey("DesciplineId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AWMS.datalayer.Entities.DescriptionForPk", "DescriptionForPk")
                        .WithMany("PackingLists")
                        .HasForeignKey("DescriptionForPkId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AWMS.datalayer.Entities.Irn", "Irn")
                        .WithMany("PackingLists")
                        .HasForeignKey("IrnId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AWMS.datalayer.Entities.Mr", "Mr")
                        .WithMany("PackingLists")
                        .HasForeignKey("MrId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AWMS.datalayer.Entities.Po", "Po")
                        .WithMany("PackingLists")
                        .HasForeignKey("PoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AWMS.datalayer.Entities.Shipment", "Shipment")
                        .WithMany("PackingLists")
                        .HasForeignKey("ShId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AWMS.datalayer.Entities.Supplier", "Supplier")
                        .WithMany("PackingLists")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AWMS.datalayer.Entities.Vendor", "Vendor")
                        .WithMany("PackingLists")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("AreaUnit");

                    b.Navigation("Descipline");

                    b.Navigation("DescriptionForPk");

                    b.Navigation("Irn");

                    b.Navigation("Mr");

                    b.Navigation("Po");

                    b.Navigation("Shipment");

                    b.Navigation("Supplier");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Po", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Mr", "Mr")
                        .WithMany("Pos")
                        .HasForeignKey("MrId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Mr");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Shipment", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Po", "Po")
                        .WithMany("Shipments")
                        .HasForeignKey("PoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Po");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.AreaUnit", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Descipline", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.DescriptionForPk", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Irn", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Mr", b =>
                {
                    b.Navigation("PackingLists");

                    b.Navigation("Pos");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.PackingList", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Po", b =>
                {
                    b.Navigation("PackingLists");

                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Shipment", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Supplier", b =>
                {
                    b.Navigation("PackingLists");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Vendor", b =>
                {
                    b.Navigation("PackingLists");
                });
#pragma warning restore 612, 618
        }
    }
}
