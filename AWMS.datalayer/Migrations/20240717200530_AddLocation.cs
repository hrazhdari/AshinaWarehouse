using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 18, 0, 35, 30, 543, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 18, 0, 35, 30, 543, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.InsertData(
                table: "Desciplines",
                columns: new[] { "DesciplineId", "DesciplineName" },
                values: new object[,]
                {
                    { 12, "Hydraulics" },
                    { 13, "HVAC" },
                    { 14, "Automation" },
                    { 15, "Safety" },
                    { 16, "Quality Control" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "EditedBy", "EditedDate", "EnteredBy", "EnteredDate", "LocationName" },
                values: new object[,]
                {
                    { 1, null, null, 88, new DateTime(2024, 7, 18, 0, 35, 30, 543, DateTimeKind.Local).AddTicks(2584), "L02A101A" },
                    { 2, null, null, 88, new DateTime(2024, 7, 18, 0, 35, 30, 543, DateTimeKind.Local).AddTicks(2641), "L02A102A" },
                    { 3, null, null, 88, new DateTime(2024, 7, 18, 0, 35, 30, 543, DateTimeKind.Local).AddTicks(2643), "W02A02B" }
                });

            migrationBuilder.InsertData(
                table: "Scopes",
                columns: new[] { "ScopeID", "ScopeName" },
                values: new object[,]
                {
                    { 1, "Fitting" },
                    { 2, "Flange" },
                    { 3, "Pipe" },
                    { 4, "Elbow" }
                });

            migrationBuilder.InsertData(
                table: "UnitPrices",
                columns: new[] { "UnitPriceID", "UnitPriceName" },
                values: new object[,]
                {
                    { 1, "Euro" },
                    { 2, "Rial" },
                    { 3, "Dollar US" },
                    { 4, "Pound UK" },
                    { 5, "Yen Japan" },
                    { 6, "Rupee India" },
                    { 7, "Yuan China" },
                    { 8, "Won South Korea" },
                    { 9, "Franc Switzerland" },
                    { 10, "Krone Denmark" },
                    { 11, "Lira Turkey" },
                    { 12, "Real Brazil" },
                    { 13, "Rand South Africa" },
                    { 14, "Baht Thailand" },
                    { 15, "Peso Mexico" },
                    { 16, "Ringgit Malaysia" },
                    { 17, "Zloty Poland" },
                    { 18, "Dirham UAE" },
                    { 19, "Dinar Kuwait" },
                    { 20, "Kuna Croatia" },
                    { 21, "Forint Hungary" },
                    { 22, "Leu Romania" },
                    { 23, "Shekel Israel" },
                    { 24, "Taka Bangladesh" },
                    { 25, "Krone Norway" },
                    { 26, "Krona Sweden" },
                    { 27, "Franc France" },
                    { 28, "Pound Egypt" },
                    { 29, "Euro Germany" },
                    { 30, "Dollar Australia" },
                    { 31, "Dollar Canada" },
                    { 32, "Dollar Singapore" },
                    { 33, "Pound Switzerland" },
                    { 34, "Franc Belgium" },
                    { 35, "Crown Czech Republic" },
                    { 36, "Krona Iceland" },
                    { 37, "Euro Ireland" },
                    { 38, "Lira Italy" },
                    { 39, "Dollar New Zealand" },
                    { 40, "Riyal Saudi Arabia" },
                    { 41, "Ruble Russia" },
                    { 42, "Pound Sterling" },
                    { 43, "Dollar Hong Kong" },
                    { 44, "Pound Lebanon" },
                    { 45, "Franc Belgium" },
                    { 46, "Dollar Taiwan" },
                    { 47, "Dinar Bahrain" },
                    { 48, "Dollar Brunei" },
                    { 49, "Pound Cyprus" },
                    { 50, "Dinar Jordan" },
                    { 51, "Baht Thailand" },
                    { 52, "Dollar Egypt" },
                    { 53, "Dollar China" },
                    { 54, "Euro Ukraine" },
                    { 55, "Dollar Mexico" },
                    { 56, "Euro Portugal" },
                    { 57, "Dollar Argentina" },
                    { 58, "Ruble Armenia" },
                    { 59, "Ruble Azerbaijan" },
                    { 60, "Euro Belgium" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "UnitID", "UnitName" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "KG" },
                    { 3, "METER" },
                    { 4, "LITER" },
                    { 5, "BOX" },
                    { 6, "PACK" },
                    { 7, "SET" },
                    { 8, "PAIR" },
                    { 9, "DOZEN" },
                    { 10, "GALLON" },
                    { 11, "TON" },
                    { 12, "GRAM" },
                    { 13, "LB" },
                    { 14, "OZ" },
                    { 15, "INCH" },
                    { 16, "FOOT" },
                    { 17, "YARD" },
                    { 18, "CM" },
                    { 19, "MM" },
                    { 20, "SQM" },
                    { 21, "CUBICM" },
                    { 22, "LTR" },
                    { 23, "BLK" },
                    { 24, "PALLET" },
                    { 25, "ROLL" },
                    { 26, "SHEET" },
                    { 27, "TUBE" },
                    { 28, "CARTON" },
                    { 29, "BAG" },
                    { 30, "CAN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationName",
                table: "Locations",
                column: "LocationName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DeleteData(
                table: "Desciplines",
                keyColumn: "DesciplineId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Desciplines",
                keyColumn: "DesciplineId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Desciplines",
                keyColumn: "DesciplineId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Desciplines",
                keyColumn: "DesciplineId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Desciplines",
                keyColumn: "DesciplineId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Scopes",
                keyColumn: "ScopeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scopes",
                keyColumn: "ScopeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Scopes",
                keyColumn: "ScopeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Scopes",
                keyColumn: "ScopeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UnitPrices",
                keyColumn: "UnitPriceID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "UnitID",
                keyValue: 30);

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
        }
    }
}
