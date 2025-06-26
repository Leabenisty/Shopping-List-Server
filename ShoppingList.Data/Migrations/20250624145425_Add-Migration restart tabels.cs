using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingList.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationrestarttabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataOrderList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataOrderList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataProduct_DataOrderList_OrderListId",
                        column: x => x.OrderListId,
                        principalTable: "DataOrderList",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "DataCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "מוצרי ניקיון" },
                    { 2, "גבינות" },
                    { 3, "ירקות ופירות" },
                    { 4, "בשר ודגים" },
                    { 5, "מאפים" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataProduct_OrderListId",
                table: "DataProduct",
                column: "OrderListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataCategory");

            migrationBuilder.DropTable(
                name: "DataProduct");

            migrationBuilder.DropTable(
                name: "DataOrderList");
        }
    }
}
