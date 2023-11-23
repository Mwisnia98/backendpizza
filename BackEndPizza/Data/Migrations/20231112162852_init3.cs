using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndPizza.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryProductId",
                schema: "shop",
                table: "producs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MainProduct",
                schema: "shop",
                table: "producs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "category_producs",
                schema: "shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_producs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_producs_CategoryProductId",
                schema: "shop",
                table: "producs",
                column: "CategoryProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_producs_category_producs_CategoryProductId",
                schema: "shop",
                table: "producs",
                column: "CategoryProductId",
                principalSchema: "shop",
                principalTable: "category_producs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_producs_category_producs_CategoryProductId",
                schema: "shop",
                table: "producs");

            migrationBuilder.DropTable(
                name: "category_producs",
                schema: "shop");

            migrationBuilder.DropIndex(
                name: "IX_producs_CategoryProductId",
                schema: "shop",
                table: "producs");

            migrationBuilder.DropColumn(
                name: "CategoryProductId",
                schema: "shop",
                table: "producs");

            migrationBuilder.DropColumn(
                name: "MainProduct",
                schema: "shop",
                table: "producs");
        }
    }
}
