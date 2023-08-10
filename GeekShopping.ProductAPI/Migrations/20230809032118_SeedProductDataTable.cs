using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "t-shirt", "camiseta sadasd adsdasd  dasda  asdsad ", "https://picsum.photos/v2/list?page=2&limit=100", "camisa manga", 19.9m },
                    { 3L, "t-shirt", "camiseta sadasd adsdasd  dasda  asdsad ", "https://picsum.photos/v2/list?page=2&limit=100", "camisa gola", 19.9m },
                    { 4L, "t-shirt", "camiseta sadasd adsdasd  dasda  asdsad ", "https://picsum.photos/v2/list?page=2&limit=100", "camisa sem manga", 19.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
