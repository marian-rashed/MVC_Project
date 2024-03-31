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
                value: new DateTime(2024, 3, 30, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 16, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 15, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 14, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 11, 15, 35, 14, 708, DateTimeKind.Local).AddTicks(2681));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 16, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 15, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 14, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 13, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 11, 13, 8, 7, 836, DateTimeKind.Local).AddTicks(6039));
        }
    }
}
