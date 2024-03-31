using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 16, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 15, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 14, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 19, 32, 40, 895, DateTimeKind.Local).AddTicks(3110));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 16, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 15, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 14, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 18, 57, 56, 84, DateTimeKind.Local).AddTicks(2080));
        }
    }
}
