using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class releaseitemUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_released_item_Units_UnitId",
                table: "released_item");

            migrationBuilder.DropForeignKey(
                name: "FK_released_item_items_ItemId",
                table: "released_item");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermit_suppliers_SupplierID",
                table: "ReleasePermit");

            migrationBuilder.DropIndex(
                name: "IX_released_item_ItemId",
                table: "released_item");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "released_item");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "released_item");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "ReleasePermit",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_ReleasePermit_SupplierID",
                table: "ReleasePermit",
                newName: "IX_ReleasePermit_CustomerID");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "released_item",
                newName: "warehouseItemId");

            migrationBuilder.RenameIndex(
                name: "IX_released_item_UnitId",
                table: "released_item",
                newName: "IX_released_item_warehouseItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_released_item_WarehouseItem_warehouseItemId",
                table: "released_item",
                column: "warehouseItemId",
                principalTable: "WarehouseItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermit_Customers_CustomerID",
                table: "ReleasePermit",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_released_item_WarehouseItem_warehouseItemId",
                table: "released_item");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleasePermit_Customers_CustomerID",
                table: "ReleasePermit");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "ReleasePermit",
                newName: "SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ReleasePermit_CustomerID",
                table: "ReleasePermit",
                newName: "IX_ReleasePermit_SupplierID");

            migrationBuilder.RenameColumn(
                name: "warehouseItemId",
                table: "released_item",
                newName: "UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_released_item_warehouseItemId",
                table: "released_item",
                newName: "IX_released_item_UnitId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "released_item",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "released_item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_released_item_ItemId",
                table: "released_item",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_released_item_Units_UnitId",
                table: "released_item",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_released_item_items_ItemId",
                table: "released_item",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasePermit_suppliers_SupplierID",
                table: "ReleasePermit",
                column: "SupplierID",
                principalTable: "suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
