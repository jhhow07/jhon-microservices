using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class FeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Electronics", "Ergonomic wireless mouse with adjustable DPI and silent clicks.", "https://picsum.photos/id/102/300/200", "Wireless Mouse", 29.99m },
                    { 3L, "Electronics", "RGB backlit mechanical keyboard with blue switches.", "https://picsum.photos/id/104/300/200", "Mechanical Keyboard", 89.5m },
                    { 4L, "Accessories", "1-liter stainless steel reusable water bottle.", "https://picsum.photos/id/1080/300/200", "Water Bottle", 15.75m },
                    { 5L, "Audio", "Over-ear headphones with active noise cancellation and 30-hour battery life.", "https://picsum.photos/id/180/300/200", "Noise Cancelling Headphones", 129.99m },
                    { 6L, "Wearables", "Fitness-focused smartwatch with heart rate monitoring and GPS.", "https://picsum.photos/id/249/300/200", "Smartwatch", 199.99m },
                    { 7L, "Furniture", "Comfortable ergonomic gaming chair with lumbar support.", "https://picsum.photos/id/335/300/200", "Gaming Chair", 299m },
                    { 8L, "Home Office", "Adjustable LED desk lamp with touch control and USB charging port.", "https://picsum.photos/id/151/300/200", "LED Desk Lamp", 39.9m },
                    { 9L, "Accessories", "Durable laptop backpack with multiple compartments and waterproof material.", "https://picsum.photos/id/1011/300/200", "Backpack", 59.99m },
                    { 10L, "Audio", "Compact wireless speaker with powerful sound and 10-hour battery life.", "https://picsum.photos/id/241/300/200", "Portable Bluetooth Speaker", 49.99m },
                    { 11L, "Footwear", "Lightweight and breathable running shoes for daily training.", "https://picsum.photos/id/21/300/200", "Running Shoes", 120m }
                });
        }

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

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
