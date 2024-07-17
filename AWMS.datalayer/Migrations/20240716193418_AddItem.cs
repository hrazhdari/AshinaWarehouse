using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PKID = table.Column<int>(type: "int", nullable: false),
                    ItemOfPk = table.Column<int>(type: "int", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UnitID = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OverQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShortageQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DamageQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IncorectQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ScopeID = table.Column<int>(type: "int", nullable: true),
                    HeatNo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BatchNo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MTRNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LabelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitPriceID = table.Column<int>(type: "int", nullable: true),
                    NetW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ItemCodeId = table.Column<int>(type: "int", nullable: true),
                    BaseMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hold = table.Column<bool>(type: "bit", nullable: true),
                    NIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StorageCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Packages_PKID",
                        column: x => x.PKID,
                        principalTable: "Packages",
                        principalColumn: "PKID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Item_PKID",
                table: "Items",
                column: "PKID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ScopeID",
                table: "Items",
                column: "ScopeID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UnitID",
                table: "Items",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_UnitPriceID",
                table: "Items",
                column: "UnitPriceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 15, 12, 14, 27, 685, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 15, 12, 14, 27, 685, DateTimeKind.Local).AddTicks(501));
        }
    }
}
