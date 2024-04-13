using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class o : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 16, 44, 57, 581, DateTimeKind.Local).AddTicks(1953));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 15, 43, 43, 246, DateTimeKind.Local).AddTicks(8208));
        }
    }
}
