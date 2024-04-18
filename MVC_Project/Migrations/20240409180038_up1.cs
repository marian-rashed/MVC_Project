using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class up1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "1",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "10",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "11",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "12",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "13",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "14",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "15",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "2",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "3",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "4",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "5",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "6",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "7",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "8",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "9",
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 9, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 8, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 7, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 6, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 20, 0, 36, 904, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Authors",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 5, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 4, 3, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 4, 2, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 4, 1, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 3, 31, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 3, 30, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 3, 29, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 3, 28, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 3, 26, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 3, 25, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 3, 24, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 3, 23, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 3, 22, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 3, 21, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 3, 20, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 3, 19, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 3, 18, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 3, 17, 15, 39, 46, 354, DateTimeKind.Local).AddTicks(8577));
        }
    }
}
