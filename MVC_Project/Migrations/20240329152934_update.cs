using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName", "Biography", "BirthDate", "Country" },
                values: new object[,]
                {
                    { 1, "Sandra Cisneros", "Sandra Cisneros is an American writer best known for her acclaimed first novel The House on Mango Street.", new DateTime(1954, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States" },
                    { 2, "Gabriel Garcia Marquez", "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo or Gabito throughout Latin America.", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombia" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FullName", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown, USA", "john_doe@example.com", "John Doe", "password123", "123-456-7890", "john_doe" },
                    { 2, "456 Oak St, Anycity, USA", "jane_smith@example.com", "Jane Smith", "password456", "987-654-3210", "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Price", "QuantityAvailable", "Title" },
                values: new object[,]
                {
                    { 1, 1, 10.99m, 50, "The House on Mango Street" },
                    { 2, 2, 12.50m, 30, "One Hundred Years of Solitude" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 29, 17, 29, 33, 376, DateTimeKind.Local).AddTicks(9264), 10.99m },
                    { 2, 2, new DateTime(2024, 3, 28, 17, 29, 33, 376, DateTimeKind.Local).AddTicks(9320), 25.00m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "BookId", "OrderId", "PricePerUnit", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 10.99m, 1 },
                    { 2, 2, 2, 12.50m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
