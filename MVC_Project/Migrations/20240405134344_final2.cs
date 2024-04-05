using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class final2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 15, 40, 48, 52, DateTimeKind.Local).AddTicks(3592));
        }
    }
}
