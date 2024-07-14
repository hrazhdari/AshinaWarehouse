using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexToPackingList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_VendorId",
                table: "PackingLists",
                newName: "IX_PackingList_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_SupplierId",
                table: "PackingLists",
                newName: "IX_PackingList_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_ShId",
                table: "PackingLists",
                newName: "IX_PackingList_ShId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_PoId",
                table: "PackingLists",
                newName: "IX_PackingList_PoId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_MrId",
                table: "PackingLists",
                newName: "IX_PackingList_MrId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_IrnId",
                table: "PackingLists",
                newName: "IX_PackingList_IrnId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_DescriptionForPkId",
                table: "PackingLists",
                newName: "IX_PackingList_DescriptionForPkId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_DesciplineId",
                table: "PackingLists",
                newName: "IX_PackingList_DesciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingLists_AreaUnitID",
                table: "PackingLists",
                newName: "IX_PackingList_AreaUnitID");

            migrationBuilder.AlterColumn<string>(
                name: "PLNO",
                table: "PackingLists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OPINO",
                table: "PackingLists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArchiveNO",
                table: "PackingLists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_ArchiveNO",
                table: "PackingLists",
                column: "ArchiveNO");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_OPINO",
                table: "PackingLists",
                column: "OPINO",
                unique: true,
                filter: "[OPINO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_PLNO",
                table: "PackingLists",
                column: "PLNO",
                unique: true,
                filter: "[PLNO] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PackingList_ArchiveNO",
                table: "PackingLists");

            migrationBuilder.DropIndex(
                name: "IX_PackingList_OPINO",
                table: "PackingLists");

            migrationBuilder.DropIndex(
                name: "IX_PackingList_PLNO",
                table: "PackingLists");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_VendorId",
                table: "PackingLists",
                newName: "IX_PackingLists_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_SupplierId",
                table: "PackingLists",
                newName: "IX_PackingLists_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_ShId",
                table: "PackingLists",
                newName: "IX_PackingLists_ShId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_PoId",
                table: "PackingLists",
                newName: "IX_PackingLists_PoId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_MrId",
                table: "PackingLists",
                newName: "IX_PackingLists_MrId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_IrnId",
                table: "PackingLists",
                newName: "IX_PackingLists_IrnId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_DescriptionForPkId",
                table: "PackingLists",
                newName: "IX_PackingLists_DescriptionForPkId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_DesciplineId",
                table: "PackingLists",
                newName: "IX_PackingLists_DesciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_PackingList_AreaUnitID",
                table: "PackingLists",
                newName: "IX_PackingLists_AreaUnitID");

            migrationBuilder.AlterColumn<string>(
                name: "PLNO",
                table: "PackingLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OPINO",
                table: "PackingLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArchiveNO",
                table: "PackingLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 12, 22, 41, 20, 719, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2,
                column: "EnteredDate",
                value: new DateTime(2024, 7, 12, 22, 41, 20, 719, DateTimeKind.Local).AddTicks(7071));
        }
    }
}
