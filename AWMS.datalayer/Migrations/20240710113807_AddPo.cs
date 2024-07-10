using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddPo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pos",
                columns: table => new
                {
                    PoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrId = table.Column<int>(type: "int", nullable: false),
                    PoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pos", x => x.PoId);
                    table.ForeignKey(
                        name: "FK_Pos_Mrs_MrId",
                        column: x => x.MrId,
                        principalTable: "Mrs",
                        principalColumn: "MrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Mrs",
                keyColumn: "MrId",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.InsertData(
                table: "Pos",
                columns: new[] { "PoId", "EnteredDate", "MrId", "PoDescription", "PoName" },
                values: new object[] { 1, new DateTime(2024, 7, 10, 16, 8, 7, 111, DateTimeKind.Local).AddTicks(7347), 1, null, "-" });

            migrationBuilder.CreateIndex(
                name: "IX_Pos_MrId",
                table: "Pos",
                column: "MrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pos");

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
                column: "EnteredDate",
                value: new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Mrs",
                keyColumn: "MrId",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 9, 18, 29, 52, 699, DateTimeKind.Local).AddTicks(9129));
        }
    }
}
