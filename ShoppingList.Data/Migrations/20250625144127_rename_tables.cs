using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingList.Data.Migrations
{
    /// <inheritdoc />
    public partial class rename_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_DataCategory_CategoryID",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_DataOrderList_OrderID",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataOrderList",
                table: "DataOrderList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataCategory",
                table: "DataCategory");

            migrationBuilder.RenameTable(
                name: "DataOrderList",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "DataCategory",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Category_CategoryID",
                table: "OrderProduct",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderID",
                table: "OrderProduct",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Category_CategoryID",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderID",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "DataOrderList");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "DataCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataOrderList",
                table: "DataOrderList",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataCategory",
                table: "DataCategory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_DataCategory_CategoryID",
                table: "OrderProduct",
                column: "CategoryID",
                principalTable: "DataCategory",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_DataOrderList_OrderID",
                table: "OrderProduct",
                column: "OrderID",
                principalTable: "DataOrderList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
