using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.MicroService.Migrations
{
    public partial class dataupdatev4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 175, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 176, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 176, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_At", "Price" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2420), 25.499m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 24, 57, 177, DateTimeKind.Local).AddTicks(2422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created_At", "Modified_At", "Name" },
                values: new object[] { 4, new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8577), null, "Televizyon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created_At", "Price" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8902), 9.499m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8904));
        }
    }
}
