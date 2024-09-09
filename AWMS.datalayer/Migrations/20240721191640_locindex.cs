using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class locindex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LocItem_ItemId",
                table: "LocItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocItem_LocationID",
                table: "LocItems",
                column: "LocationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LocItem_ItemId",
                table: "LocItems");

            migrationBuilder.DropIndex(
                name: "IX_LocItem_LocationID",
                table: "LocItems");
        }
    }
}
