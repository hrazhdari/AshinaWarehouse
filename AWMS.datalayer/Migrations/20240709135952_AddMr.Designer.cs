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
    [Migration("20240709135952_AddMr")]
    partial class AddMr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            EnteredDate = new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(8958)
                        },
                        new
                        {
                            CompanyID = 2,
                            Abbreviation = "TESCO",
                            CompanyName = "Teco",
                            EnteredDate = new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9012)
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

            modelBuilder.Entity("AWMS.datalayer.Entities.Mr", b =>
                {
                    b.Property<int>("MrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MrId"));

                    b.Property<DateTime?>("EnteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MrDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MrId");

                    b.ToTable("Mrs");

                    b.HasData(
                        new
                        {
                            MrId = 1,
                            EnteredDate = new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9129),
                            MrName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.CompanyContract", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
