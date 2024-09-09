using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class contractChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditedBy",
                table: "CompanyContracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedDate",
                table: "CompanyContracts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnteredBy",
                table: "CompanyContracts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 12, 11, 58, 1, 704, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 12, 11, 58, 1, 704, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 12, 11, 58, 1, 703, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 12, 11, 58, 1, 703, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 12, 11, 58, 1, 703, DateTimeKind.Local).AddTicks(9871));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "CompanyContracts");

            migrationBuilder.DropColumn(
                name: "EditedDate",
                table: "CompanyContracts");

            migrationBuilder.DropColumn(
                name: "EnteredBy",
                table: "CompanyContracts");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 3, 20, 27, 39, 935, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 3, 20, 27, 39, 935, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 3, 20, 27, 39, 935, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 3, 20, 27, 39, 935, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 3, 20, 27, 39, 935, DateTimeKind.Local).AddTicks(540));
        }
    }
}
