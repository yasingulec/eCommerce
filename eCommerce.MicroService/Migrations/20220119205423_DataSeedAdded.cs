using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.MicroService.Migrations
{
    public partial class DataSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created_At", "Modified_At", "Name" },
                values: new object[] { 1, new DateTime(2022, 1, 19, 23, 54, 23, 487, DateTimeKind.Local).AddTicks(4903), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgisayar" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created_At", "Description", "Modified_At", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, 1, new DateTime(2022, 1, 19, 23, 54, 23, 489, DateTimeKind.Local).AddTicks(2888), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.499m, "Huawei Matebook D 16", 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
