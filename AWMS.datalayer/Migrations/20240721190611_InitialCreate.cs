using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWMS.datalayer.Migrations
{
    // <inheritdoc />
    public partial class InitialCreate : Migration
    {
        // <inheritdoc />
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
                    ArchiveNO = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PLNO = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OPINO = table.Column<string>(type: "nvarchar(450)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLId = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    NetW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossW = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dimension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "date", nullable: true),
                    Desciption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "date", nullable: true),
                    MSRNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MSRPDF = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MSRDate = table.Column<DateTime>(type: "date", nullable: true),
                    MSREnteredBy = table.Column<int>(type: "int", nullable: true),
                    MSRStatus = table.Column<bool>(type: "bit", nullable: true),
                    MSRRev = table.Column<int>(type: "int", nullable: true),
                    MSRRevEnteredBy = table.Column<int>(type: "int", nullable: true),
                    MSRRevDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PKID);
                    table.ForeignKey(
                        name: "FK_Packages_PackingLists_PLId",
                        column: x => x.PLId,
                        principalTable: "PackingLists",
                        principalColumn: "PLId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_Items_Scopes_ScopeID",
                        column: x => x.ScopeID,
                        principalTable: "Scopes",
                        principalColumn: "ScopeID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Items_UnitPrices_UnitPriceID",
                        column: x => x.UnitPriceID,
                        principalTable: "UnitPrices",
                        principalColumn: "UnitPriceID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Items_Units_UnitID",
                        column: x => x.UnitID,
                        principalTable: "Units",
                        principalColumn: "UnitID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "LocItems",
                columns: table => new
                {
                    LocItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OverQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShortageQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DamageQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RejectQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NISQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EnteredBy = table.Column<int>(type: "int", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "date", nullable: true),
                    EditedBy = table.Column<int>(type: "int", nullable: true),
                    EditedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocItems", x => x.LocItemID);
                    table.ForeignKey(
                        name: "FK_LocItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocItems_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "PPI", null, "Petro Paydar Iranian", new DateTime(2024, 7, 21, 23, 36, 11, 523, DateTimeKind.Local).AddTicks(9692), null, null },
                    { 2, "TESCO", null, "Teco", new DateTime(2024, 7, 21, 23, 36, 11, 523, DateTimeKind.Local).AddTicks(9706), null, null }
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
                    { 11, "Other" },
                    { 12, "Hydraulics" },
                    { 13, "HVAC" },
                    { 14, "Automation" },
                    { 15, "Safety" },
                    { 16, "Quality Control" }
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
                table: "Locations",
                columns: new[] { "LocationID", "EditedBy", "EditedDate", "EnteredBy", "EnteredDate", "LocationName" },
                values: new object[,]
                {
                    { 1, null, null, 88, new DateTime(2024, 7, 21, 23, 36, 11, 523, DateTimeKind.Local).AddTicks(8116), "L02A101A" },
                    { 2, null, null, 88, new DateTime(2024, 7, 21, 23, 36, 11, 523, DateTimeKind.Local).AddTicks(8169), "L02A102A" },
                    { 3, null, null, 88, new DateTime(2024, 7, 21, 23, 36, 11, 523, DateTimeKind.Local).AddTicks(8172), "W02A02B" }
                });

            migrationBuilder.InsertData(
                table: "Mrs",
                columns: new[] { "MrId", "EnteredDate", "MrDescription", "MrName" },
                values: new object[] { 1, null, null, "-" });

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
                table: "Suppliers",
                columns: new[] { "SupplierId", "EnteredDate", "SupplierName", "SupplierRemark" },
                values: new object[] { 1, null, "-", "-" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationName",
                table: "Locations",
                column: "LocationName");

            migrationBuilder.CreateIndex(
                name: "IX_Package_MSRNO",
                table: "Packages",
                column: "MSRNO");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PK",
                table: "Packages",
                column: "PK");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PLId",
                table: "Packages",
                column: "PLId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_ArchiveNO",
                table: "PackingLists",
                column: "ArchiveNO");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_AreaUnitID",
                table: "PackingLists",
                column: "AreaUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_DesciplineId",
                table: "PackingLists",
                column: "DesciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_DescriptionForPkId",
                table: "PackingLists",
                column: "DescriptionForPkId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_IrnId",
                table: "PackingLists",
                column: "IrnId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_MrId",
                table: "PackingLists",
                column: "MrId");

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

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_PoId",
                table: "PackingLists",
                column: "PoId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_ShId",
                table: "PackingLists",
                column: "ShId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_SupplierId",
                table: "PackingLists",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingList_VendorId",
                table: "PackingLists",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pos_MrId",
                table: "Pos",
                column: "MrId");

            migrationBuilder.CreateIndex(
                name: "IX_Scope_ScopeName",
                table: "Scopes",
                column: "ScopeName");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_PoId",
                table: "Shipments",
                column: "PoId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitPrice_UnitPriceName",
                table: "UnitPrices",
                column: "UnitPriceName");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_UnitName",
                table: "Units",
                column: "UnitName");
        }

        // <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContracts");

            migrationBuilder.DropTable(
                name: "LocItems");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Scopes");

            migrationBuilder.DropTable(
                name: "UnitPrices");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "PackingLists");

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
