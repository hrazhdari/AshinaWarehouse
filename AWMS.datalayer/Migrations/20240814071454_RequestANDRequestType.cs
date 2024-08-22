using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class RequestANDRequestType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    ReqLocItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocItemID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    CompanyID2 = table.Column<int>(type: "int", nullable: true),
                    ContractId = table.Column<int>(type: "int", nullable: true),
                    ContractId2 = table.Column<int>(type: "int", nullable: true),
                    AreaUnitID = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    RequestNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqDate = table.Column<DateTime>(type: "date", nullable: true),
                    Item = table.Column<int>(type: "int", nullable: true),
                    ReqMivQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReserveMivQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelMivQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReqMivRejQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReserveMivRejQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelMivRejQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReqMrvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReserveMrvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelMrvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelMrvRejQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReqHmvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReserveHmvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelHmvQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DelHmvRejQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IssuedBy = table.Column<int>(type: "int", nullable: true),
                    IssuedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: true),
                    DelDate = table.Column<DateTime>(type: "date", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRVNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HMVNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestPDF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestTypeTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ReqLocItemID);
                    table.ForeignKey(
                        name: "FK_Requests_LocItems_LocItemID",
                        column: x => x.LocItemID,
                        principalTable: "LocItems",
                        principalColumn: "LocItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_RequestTypes_RequestTypeTypeID",
                        column: x => x.RequestTypeTypeID,
                        principalTable: "RequestTypes",
                        principalColumn: "TypeID");
                });

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

            migrationBuilder.InsertData(
                table: "RequestTypes",
                columns: new[] { "TypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "MIV" },
                    { 2, "MIVReject" },
                    { 3, "HMV" },
                    { 4, "MRV" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_CompanyID",
                table: "Requests",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_LocItemID",
                table: "Requests",
                column: "LocItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_TypeID",
                table: "Requests",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestTypeTypeID",
                table: "Requests",
                column: "RequestTypeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestType_TypeName",
                table: "RequestTypes",
                column: "TypeName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "RequestTypes");

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
    }
}
