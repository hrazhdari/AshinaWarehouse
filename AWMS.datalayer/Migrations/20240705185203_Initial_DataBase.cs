using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial_DataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local_Foreign = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContracts",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContracts", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_CompanyContracts_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "Abbreviation", "CompanyLogo", "CompanyName", "EnteredDate", "Local_Foreign", "Remark" },
                values: new object[,]
                {
                    { 1, "PPI", null, "Petro Paydar Iranian", new DateTime(2024, 7, 5, 23, 22, 2, 816, DateTimeKind.Local).AddTicks(3779), null, null },
                    { 2, "MAPNA", null, "MAPNA", new DateTime(2024, 7, 5, 23, 22, 2, 816, DateTimeKind.Local).AddTicks(3828), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContracts_CompanyID",
                table: "CompanyContracts",
                column: "CompanyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContracts");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
