using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaUnits",
                columns: table => new
                {
                    AreaUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaUnitName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AreaUnitDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AreaUnitTrain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaUnits", x => x.AreaUnitID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local_Foreign = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Desciplines",
                columns: table => new
                {
                    DesciplineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesciplineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desciplines", x => x.DesciplineId);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionForPks",
                columns: table => new
                {
                    DescriptionForPkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionForPks", x => x.DescriptionForPkId);
                });

            migrationBuilder.CreateTable(
                name: "Irns",
                columns: table => new
                {
                    IrnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IrnName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IrnDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IrnPdf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Irns", x => x.IrnId);
                });

            migrationBuilder.CreateTable(
                name: "Mrs",
                columns: table => new
                {
                    MrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MrDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mrs", x => x.MrId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SupplierRemark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VendorContractNO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VendorContractDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VendorAbbreviation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Local_Foreign = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContracts",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContracts", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_CompanyContracts_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "Pos",
                columns: table => new
                {
                    PoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MrId = table.Column<int>(type: "int", nullable: true),
                    PoName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PoDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pos", x => x.PoId);
                    table.ForeignKey(
                        name: "FK_Pos_Mrs_MrId",
                        column: x => x.MrId,
                        principalTable: "Mrs",
                        principalColumn: "MrId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    ShipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoId = table.Column<int>(type: "int", nullable: true),
                    ShipmentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ShipmentDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.ShipmentId);
                    table.ForeignKey(
                        name: "FK_Shipments_Pos_PoId",
                        column: x => x.PoId,
                        principalTable: "Pos",
                        principalColumn: "PoId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PackingLists",
                columns: table => new
                {
                    PLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShId = table.Column<int>(type: "int", nullable: true),
                    MrId = table.Column<int>(type: "int", nullable: true),
                    PoId = table.Column<int>(type: "int", nullable: true),
                    IrnId = table.Column<int>(type: "int", nullable: true),
                    PLName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ArchiveNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPINO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaUnitID = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    DesciplineId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    DescriptionForPkId = table.Column<int>(type: "int", nullable: true),
                    NetW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vessel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MARDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalForeign = table.Column<int>(type: "int", nullable: true),
                    RTINO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IRCNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LCNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BLNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarkcustoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PLDPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<bool>(type: "bit", nullable: true),
                    Attachment = table.Column<bool>(type: "bit", nullable: true),
                    SitePL = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackingLists", x => x.PLId);
                    table.ForeignKey(
                        name: "FK_PackingLists_AreaUnits_AreaUnitID",
                        column: x => x.AreaUnitID,
                        principalTable: "AreaUnits",
                        principalColumn: "AreaUnitID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Desciplines_DesciplineId",
                        column: x => x.DesciplineId,
                        principalTable: "Desciplines",
                        principalColumn: "DesciplineId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_DescriptionForPks_DescriptionForPkId",
                        column: x => x.DescriptionForPkId,
                        principalTable: "DescriptionForPks",
                        principalColumn: "DescriptionForPkId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Irns_IrnId",
                        column: x => x.IrnId,
                        principalTable: "Irns",
                        principalColumn: "IrnId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Mrs_MrId",
                        column: x => x.MrId,
                        principalTable: "Mrs",
                        principalColumn: "MrId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Pos_PoId",
                        column: x => x.PoId,
                        principalTable: "Pos",
                        principalColumn: "PoId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Shipments_ShId",
                        column: x => x.ShId,
                        principalTable: "Shipments",
                        principalColumn: "ShipmentId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_PackingLists_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AreaUnits",
                columns: new[] { "AreaUnitID", "AreaUnitDescription", "AreaUnitName", "AreaUnitTrain", "EnteredDate", "Remark" },
                values: new object[] { 1, "-", "-", "-", null, null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "Abbreviation", "CompanyLogo", "CompanyName", "EnteredDate", "Local_Foreign", "Remark" },
                values: new object[,]
                {
                    { 1, "PPI", null, "Petro Paydar Iranian", new DateTime(2024, 7, 12, 22, 41, 20, 719, DateTimeKind.Local).AddTicks(6999), null, null },
                    { 2, "TESCO", null, "Teco", new DateTime(2024, 7, 12, 22, 41, 20, 719, DateTimeKind.Local).AddTicks(7071), null, null }
                });

            migrationBuilder.InsertData(
                table: "Desciplines",
                columns: new[] { "DesciplineId", "DesciplineName" },
                values: new object[,]
                {
                    { 1, "Piping" },
                    { 2, "Support" },
                    { 3, "Mechanical" },
                    { 4, "Electrical" },
                    { 5, "Instrument" },
                    { 6, "Civil" },
                    { 7, "Steel Structure" },
                    { 8, "Steel Profile" },
                    { 9, "Paint" },
                    { 10, "Insulation" },
                    { 11, "Other" }
                });

            migrationBuilder.InsertData(
                table: "DescriptionForPks",
                columns: new[] { "DescriptionForPkId", "Description" },
                values: new object[] { 1, "-" });

            migrationBuilder.InsertData(
                table: "Irns",
                columns: new[] { "IrnId", "EnteredDate", "IrnDescription", "IrnName", "IrnPdf" },
                values: new object[] { 1, null, "-", "-", null });

            migrationBuilder.InsertData(
                table: "Mrs",
                columns: new[] { "MrId", "EnteredDate", "MrDescription", "MrName" },
                values: new object[] { 1, null, null, "-" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "EnteredDate", "SupplierName", "SupplierRemark" },
                values: new object[] { 1, null, "-", "-" });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorID", "EnteredDate", "Local_Foreign", "Remark", "VendorAbbreviation", "VendorContractDescription", "VendorContractNO", "VendorName" },
                values: new object[] { 1, null, null, null, "-", "-", "-", "-" });

            migrationBuilder.InsertData(
                table: "Pos",
                columns: new[] { "PoId", "EnteredDate", "MrId", "PoDescription", "PoName" },
                values: new object[] { 1, null, 1, null, "-" });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "ShipmentId", "EnteredDate", "PoId", "ShipmentDescription", "ShipmentName" },
                values: new object[] { 1, null, 1, "-", "-" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContracts_CompanyID",
                table: "CompanyContracts",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_AreaUnitID",
                table: "PackingLists",
                column: "AreaUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_DesciplineId",
                table: "PackingLists",
                column: "DesciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_DescriptionForPkId",
                table: "PackingLists",
                column: "DescriptionForPkId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_IrnId",
                table: "PackingLists",
                column: "IrnId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_MrId",
                table: "PackingLists",
                column: "MrId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_PoId",
                table: "PackingLists",
                column: "PoId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_ShId",
                table: "PackingLists",
                column: "ShId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_SupplierId",
                table: "PackingLists",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_VendorId",
                table: "PackingLists",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pos_MrId",
                table: "Pos",
                column: "MrId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_PoId",
                table: "Shipments",
                column: "PoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContracts");

            migrationBuilder.DropTable(
                name: "PackingLists");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "AreaUnits");

            migrationBuilder.DropTable(
                name: "Desciplines");

            migrationBuilder.DropTable(
                name: "DescriptionForPks");

            migrationBuilder.DropTable(
                name: "Irns");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Pos");

            migrationBuilder.DropTable(
                name: "Mrs");
        }
    }
}
