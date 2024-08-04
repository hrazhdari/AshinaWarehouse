using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class LoginSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_ApplicationRole_RoleID",
                        column: x => x.RoleID,
                        principalTable: "ApplicationRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationRole",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Master" },
                    { 4, "Amateur" },
                    { 5, "Viewer" }
                });

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

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "UserID", "PasswordHash", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, "123", 1, "Admin" },
                    { 2, "123", 4, "Amateur" },
                    { 3, "123", 3, "Master" },
                    { 4, "123", 5, "Viewer" },
                    { 5, "123", 2, "Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_RoleID",
                table: "ApplicationUser",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 31, 14, 52, 39, 4, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 31, 14, 52, 39, 4, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 31, 14, 52, 39, 3, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 31, 14, 52, 39, 3, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 31, 14, 52, 39, 3, DateTimeKind.Local).AddTicks(9448));
        }
    }
}
