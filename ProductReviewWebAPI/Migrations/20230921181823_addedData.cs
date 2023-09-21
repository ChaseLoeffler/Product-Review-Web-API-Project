using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Wok Pan", 29.989999999999998 },
                    { 2, "Heavy Duty Spatula", 4.9900000000000002 },
                    { 3, "Rice Cooker", 49.990000000000002 },
                    { 4, "Bamboo Steamer", 14.99 },
                    { 5, "Chopsticks Set", 9.9900000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ProductId", "Rating", "Text" },
                values: new object[,]
                {
                    { 1, 1, 5, "Great wok for stir-frying!" },
                    { 2, 2, 4, "Good quality product." },
                    { 3, 3, 5, "Makes perfect rice every time." },
                    { 4, 4, 4, "Perfect for steaming vegetables." },
                    { 5, 5, 4, "Nice chopsticks set for casual usage." },
                    { 6, 1, 3, "Decent wok, but could be better." },
                    { 7, 2, 2, "Melted on my stovetop." },
                    { 8, 3, 2, "Not very durable, broke after a few uses." },
                    { 9, 4, 3, "Steamer works well but could use more compartments." },
                    { 10, 5, 2, "Chopsticks are too slippery to hold properly." },
                    { 11, 1, 3, "Average wok, nothing special." },
                    { 12, 2, 3, "Standard spatula, everything you need." },
                    { 13, 3, 4, "Good value for the price." },
                    { 14, 4, 5, "Convenient for steaming various dishes." },
                    { 15, 5, 5, "Comfortable chopsticks to use." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
