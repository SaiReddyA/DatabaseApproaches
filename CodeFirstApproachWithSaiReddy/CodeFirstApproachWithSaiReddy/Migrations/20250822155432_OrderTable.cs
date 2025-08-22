using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachWithSaiReddy.Migrations
{
    /// <inheritdoc />
    public partial class OrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                           name: "Orders",
                           columns: table => new
                           {
                               Id = table.Column<int>(type: "int", nullable: false)
                                   .Annotation("SqlServer:Identity", "1, 1"),
                              ProductId = table.Column<int>(type: "int", nullable: false),
                              CategoryId = table.Column<int>(type: "int", nullable: false)
                           },
                           constraints: table =>
                           {
                               table.PrimaryKey("PK_Orders", x => x.Id);
                               table.ForeignKey(
                                   name: "FK_Orders_Products_ProductId",
                                   column: x => x.ProductId,
                                   principalTable: "Products",
                                   principalColumn: "Id",
                                   onDelete: ReferentialAction.NoAction);
                               table.ForeignKey(
                                   name: "FK_Orders_categories_categoryId",
                                   column: x => x.CategoryId,
                                   principalTable: "categories",
                                   principalColumn: "Id",
                                   onDelete: ReferentialAction.NoAction);
                           });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Orders");

        }
    }
}
