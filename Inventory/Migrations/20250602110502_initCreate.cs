using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mangerEmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                    table.ForeignKey(
                        name: "FK_Warehouses_Employee_mangerEmpId",
                        column: x => x.mangerEmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnit",
                columns: table => new
                {
                    itemsItemId = table.Column<int>(type: "int", nullable: false),
                    unitsUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnit", x => new { x.itemsItemId, x.unitsUnitId });
                    table.ForeignKey(
                        name: "FK_ItemUnit_Units_unitsUnitId",
                        column: x => x.unitsUnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemUnit_items_itemsItemId",
                        column: x => x.itemsItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReleasePermit",
                columns: table => new
                {
                    PermitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    permitNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasePermit", x => x.PermitId);
                    table.ForeignKey(
                        name: "FK_ReleasePermit_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleasePermit_suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "supply_Permit",
                columns: table => new
                {
                    PermitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    permitNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supply_Permit", x => x.PermitId);
                    table.ForeignKey(
                        name: "FK_supply_Permit_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supply_Permit_suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transfer_Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quntity = table.Column<float>(type: "real", nullable: false),
                    ProudctionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    FromWarehouseWarehouseID = table.Column<int>(type: "int", nullable: false),
                    ToWarehouseWarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfer_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transfer_Items_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transfer_Items_Warehouses_FromWarehouseWarehouseID",
                        column: x => x.FromWarehouseWarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transfer_Items_Warehouses_ToWarehouseWarehouseID",
                        column: x => x.ToWarehouseWarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID");
                    table.ForeignKey(
                        name: "FK_transfer_Items_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_transfer_Items_suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quntity = table.Column<float>(type: "real", nullable: false),
                    productionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "released_item",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quntity = table.Column<float>(type: "real", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    ReleasePermitPermitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_released_item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_released_item_ReleasePermit_ReleasePermitPermitId",
                        column: x => x.ReleasePermitPermitId,
                        principalTable: "ReleasePermit",
                        principalColumn: "PermitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_released_item_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_released_item_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplied_item",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quntity = table.Column<float>(type: "real", nullable: false),
                    ProudctionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expirationDays = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    WarehouseItemId = table.Column<int>(type: "int", nullable: false),
                    supplyPermitPermitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplied_item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Supplied_item_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplied_item_WarehouseItem_WarehouseItemId",
                        column: x => x.WarehouseItemId,
                        principalTable: "WarehouseItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Supplied_item_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplied_item_supply_Permit_supplyPermitPermitId",
                        column: x => x.supplyPermitPermitId,
                        principalTable: "supply_Permit",
                        principalColumn: "PermitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnit_unitsUnitId",
                table: "ItemUnit",
                column: "unitsUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_released_item_ItemId",
                table: "released_item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_released_item_ReleasePermitPermitId",
                table: "released_item",
                column: "ReleasePermitPermitId");

            migrationBuilder.CreateIndex(
                name: "IX_released_item_UnitId",
                table: "released_item",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermit_SupplierID",
                table: "ReleasePermit",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleasePermit_WarehouseID",
                table: "ReleasePermit",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplied_item_ItemId",
                table: "Supplied_item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplied_item_supplyPermitPermitId",
                table: "Supplied_item",
                column: "supplyPermitPermitId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplied_item_UnitId",
                table: "Supplied_item",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplied_item_WarehouseItemId",
                table: "Supplied_item",
                column: "WarehouseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_supply_Permit_SupplierID",
                table: "supply_Permit",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_supply_Permit_WarehouseID",
                table: "supply_Permit",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_FromWarehouseWarehouseID",
                table: "transfer_Items",
                column: "FromWarehouseWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_ItemId",
                table: "transfer_Items",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_SupplierID",
                table: "transfer_Items",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_ToWarehouseWarehouseID",
                table: "transfer_Items",
                column: "ToWarehouseWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_UnitId",
                table: "transfer_Items",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_ItemId",
                table: "WarehouseItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_UnitId",
                table: "WarehouseItem",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_WarehouseID",
                table: "WarehouseItem",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_mangerEmpId",
                table: "Warehouses",
                column: "mangerEmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ItemUnit");

            migrationBuilder.DropTable(
                name: "released_item");

            migrationBuilder.DropTable(
                name: "Supplied_item");

            migrationBuilder.DropTable(
                name: "transfer_Items");

            migrationBuilder.DropTable(
                name: "ReleasePermit");

            migrationBuilder.DropTable(
                name: "WarehouseItem");

            migrationBuilder.DropTable(
                name: "supply_Permit");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
