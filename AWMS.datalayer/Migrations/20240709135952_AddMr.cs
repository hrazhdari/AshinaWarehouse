using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddMr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mrs",
                columns: table => new
                {
                    MrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MrDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mrs", x => x.MrId);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                columns: new[] { "Abbreviation", "CompanyName", "EnteredDate" },
                values: new object[] { "TESCO", "Teco", new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.InsertData(
                table: "Mrs",
                columns: new[] { "MrId", "EnteredDate", "MrDescription", "MrName" },
                values: new object[] { 1, new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9129), null, "-" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mrs");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 5, 23, 22, 2, 816, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                columns: new[] { "Abbreviation", "CompanyName", "EnteredDate" },
                values: new object[] { "MAPNA", "MAPNA", new DateTime(2024, 7, 5, 23, 22, 2, 816, DateTimeKind.Local).AddTicks(3828) });
        }
    }
}
