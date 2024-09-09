using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class RequestChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReserveHmvQty",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ReserveMrvQty",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 18, 12, 58, 385, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 18, 12, 58, 385, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 18, 12, 58, 384, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 18, 12, 58, 384, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 18, 12, 58, 384, DateTimeKind.Local).AddTicks(2542));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ReserveHmvQty",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ReserveMrvQty",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 11, 44, 54, 35, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 11, 44, 54, 35, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 11, 44, 54, 34, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 11, 44, 54, 34, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "EnteredDate",
                value: new DateTime(2024, 8, 14, 11, 44, 54, 34, DateTimeKind.Local).AddTicks(7696));
        }
    }
}
