using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class change_transferItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transfer_Items_Units_UnitId",
                table: "transfer_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_transfer_Items_items_ItemId",
                table: "transfer_Items");

            migrationBuilder.DropIndex(
                name: "IX_transfer_Items_ItemId",
                table: "transfer_Items");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "transfer_Items");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "transfer_Items");

            migrationBuilder.DropColumn(
                name: "ProudctionDate",
                table: "transfer_Items");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "transfer_Items",
                newName: "warehouseItemId");

            migrationBuilder.RenameIndex(
                name: "IX_transfer_Items_UnitId",
                table: "transfer_Items",
                newName: "IX_transfer_Items_warehouseItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_transfer_Items_WarehouseItem_warehouseItemId",
                table: "transfer_Items",
                column: "warehouseItemId",
                principalTable: "WarehouseItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transfer_Items_WarehouseItem_warehouseItemId",
                table: "transfer_Items");

            migrationBuilder.RenameColumn(
                name: "warehouseItemId",
                table: "transfer_Items",
                newName: "UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_transfer_Items_warehouseItemId",
                table: "transfer_Items",
                newName: "IX_transfer_Items_UnitId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "transfer_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "transfer_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProudctionDate",
                table: "transfer_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_transfer_Items_ItemId",
                table: "transfer_Items",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_transfer_Items_Units_UnitId",
                table: "transfer_Items",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transfer_Items_items_ItemId",
                table: "transfer_Items",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
