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
    [Migration("20240710113807_AddPo")]
    partial class AddPo
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
                            EnteredDate = new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7366)
                        },
                        new
                        {
                            CompanyID = 2,
                            Abbreviation = "TESCO",
                            CompanyName = "Teco",
                            EnteredDate = new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7370)
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
                            EnteredDate = new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7195),
                            MrName = "-"
                        });
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
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoId");

                    b.HasIndex("MrId");

                    b.ToTable("Pos");

                    b.HasData(
                        new
                        {
                            PoId = 1,
                            EnteredDate = new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7347),
                            MrId = 1,
                            PoName = "-"
                        });
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.CompanyContract", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Po", b =>
                {
                    b.HasOne("AWMS.datalayer.Entities.Mr", "Mr")
                        .WithMany("Pos")
                        .HasForeignKey("MrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mr");
                });

            modelBuilder.Entity("AWMS.datalayer.Entities.Mr", b =>
                {
                    b.Navigation("Pos");
                });
#pragma warning restore 612, 618
        }
    }
}