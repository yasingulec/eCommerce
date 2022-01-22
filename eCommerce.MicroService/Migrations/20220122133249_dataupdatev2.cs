using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.MicroService.Migrations
{
    public partial class dataupdatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified_At",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified_At",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Modified_At" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 565, DateTimeKind.Local).AddTicks(3681), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Modified_At" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1464), null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created_At", "Description", "Modified_At", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1496), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 },
                    { 3, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1499), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 },
                    { 4, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1501), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 },
                    { 5, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1503), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 },
                    { 6, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1510), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 },
                    { 7, 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1512), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", null, 9.499m, "Huawei Matebook D 16", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified_At",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified_At",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Modified_At" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 54, 23, 487, DateTimeKind.Local).AddTicks(4903), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Modified_At" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 54, 23, 489, DateTimeKind.Local).AddTicks(2888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
