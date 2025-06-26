using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingList.Data.Migrations
{
    /// <inheritdoc />
    public partial class remove_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_DataProduct_ProductID",
                table: "OrderProduct");

            migrationBuilder.DropTable(
                name: "DataProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_ProductID",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "OrderProduct",
                newName: "productName");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "OrderProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_CategoryID",
                table: "OrderProduct",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_DataCategory_CategoryID",
                table: "OrderProduct",
                column: "CategoryID",
                principalTable: "DataCategory",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_DataCategory_CategoryID",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_CategoryID",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "productName",
                table: "OrderProduct",
                newName: "ProductID");

            migrationBuilder.CreateTable(
                name: "DataProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProduct", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DataProduct_DataCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "DataCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductID",
                table: "OrderProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_DataProduct_CategoryID",
                table: "DataProduct",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_DataProduct_ProductID",
                table: "OrderProduct",
                column: "ProductID",
                principalTable: "DataProduct",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
