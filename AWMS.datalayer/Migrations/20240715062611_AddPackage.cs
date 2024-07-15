using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddPackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLId = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    NetW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dimension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "date", nullable: true),
                    Desciption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "date", nullable: true),
                    MSRNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MSRPDF = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MSRDate = table.Column<DateTime>(type: "date", nullable: true),
                    MSREnteredBy = table.Column<int>(type: "int", nullable: true),
                    MSRStatus = table.Column<bool>(type: "bit", nullable: true),
                    MSRRev = table.Column<int>(type: "int", nullable: true),
                    MSRRevEnteredBy = table.Column<int>(type: "int", nullable: true),
                    MSRRevDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PKID);
                    table.ForeignKey(
                        name: "FK_Packages_PackingLists_PLId",
                        column: x => x.PLId,
                        principalTable: "PackingLists",
                        principalColumn: "PLId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 15, 10, 56, 11, 572, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 15, 10, 56, 11, 572, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.CreateIndex(
                name: "IX_Package_MSRNO",
                table: "Packages",
                column: "MSRNO");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PLId",
                table: "Packages",
                column: "PLId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 14, 21, 8, 9, 101, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 14, 21, 8, 9, 101, DateTimeKind.Local).AddTicks(3423));
        }
    }
}
