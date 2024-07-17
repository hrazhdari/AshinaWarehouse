using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitUnitPriceScope : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scopes",
                columns: table => new
                {
                    ScopeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScopeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scopes", x => x.ScopeID);
                });

            migrationBuilder.CreateTable(
                name: "UnitPrices",
                columns: table => new
                {
                    UnitPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPriceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitPrices", x => x.UnitPriceID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitID);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 17, 9, 25, 29, 6, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 17, 9, 25, 29, 6, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.CreateIndex(
                name: "IX_Item_Description",
                table: "Items",
                column: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Tag",
                table: "Items",
                column: "Tag");

            migrationBuilder.CreateIndex(
                name: "IX_Scope_ScopeName",
                table: "Scopes",
                column: "ScopeName");

            migrationBuilder.CreateIndex(
                name: "IX_UnitPrice_UnitPriceName",
                table: "UnitPrices",
                column: "UnitPriceName");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_UnitName",
                table: "Units",
                column: "UnitName");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Scopes_ScopeID",
                table: "Items",
                column: "ScopeID",
                principalTable: "Scopes",
                principalColumn: "ScopeID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UnitPrices_UnitPriceID",
                table: "Items",
                column: "UnitPriceID",
                principalTable: "UnitPrices",
                principalColumn: "UnitPriceID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Units_UnitID",
                table: "Items",
                column: "UnitID",
                principalTable: "Units",
                principalColumn: "UnitID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Scopes_ScopeID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_UnitPrices_UnitPriceID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Units_UnitID",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Scopes");

            migrationBuilder.DropTable(
                name: "UnitPrices");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Item_Description",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Item_Tag",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 17, 0, 4, 18, 192, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 17, 0, 4, 18, 192, DateTimeKind.Local).AddTicks(3875));
        }
    }
}
