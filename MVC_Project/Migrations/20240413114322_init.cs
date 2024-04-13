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
                value: new DateTime(2024, 4, 13, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 12, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 11, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 10, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 9, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 4, 8, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 4, 7, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 4, 6, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 13, 43, 21, 190, DateTimeKind.Local).AddTicks(8464));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 9, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 8, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 7, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 6, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 6, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 18, 51, 45, 463, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 15, 9, 58, 193, DateTimeKind.Local).AddTicks(9722));
        }
    }
}
