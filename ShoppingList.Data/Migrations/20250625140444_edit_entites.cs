using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingList.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit_entites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataProduct_DataOrderList_OrderListId",
                table: "DataProduct");

            migrationBuilder.DropIndex(
                name: "IX_DataProduct_OrderListId",
                table: "DataProduct");

            migrationBuilder.DropColumn(
                name: "OrderListId",
                table: "DataProduct");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "DataOrderList");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DataProduct",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "DataProduct",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DataOrderList",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DataCategory",
                newName: "ID");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderProduct_DataOrderList_OrderID",
                        column: x => x.OrderID,
                        principalTable: "DataOrderList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_DataProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "DataProduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataProduct_CategoryID",
                table: "DataProduct",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderID",
                table: "OrderProduct",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductID",
                table: "OrderProduct",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_DataProduct_DataCategory_CategoryID",
                table: "DataProduct",
                column: "CategoryID",
                principalTable: "DataCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataProduct_DataCategory_CategoryID",
                table: "DataProduct");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_DataProduct_CategoryID",
                table: "DataProduct");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DataProduct",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "DataProduct",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DataOrderList",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DataCategory",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "OrderListId",
                table: "DataProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "DataOrderList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DataProduct_OrderListId",
                table: "DataProduct",
                column: "OrderListId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataProduct_DataOrderList_OrderListId",
                table: "DataProduct",
                column: "OrderListId",
                principalTable: "DataOrderList",
                principalColumn: "Id");
        }
    }
}
