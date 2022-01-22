using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.MicroService.Migrations
{
    public partial class dataupdatev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created_At", "Modified_At", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8563), null, "Tablet" },
                    { 3, new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8575), null, "Telefon" },
                    { 4, new DateTime(2022, 1, 22, 19, 18, 33, 793, DateTimeKind.Local).AddTicks(8577), null, "Televizyon" }
                });

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
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8871), " Intel Core i3 1115G4 8GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar", 6.499m, "Dell Vostro 3500", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8874), "Intel Core i3 1115G4 4GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar 2N2N6EA", 5.298m, "HP 15S-FQ2038NT", 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8876), "Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.0'' Taşınabilir Bilgisayar", 3.999m, "Lenovo Ideapad 1 14IGL05", 83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8878), "Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 15.6\" Taşınabilir Bilgisayar", 3.949m, "Asus X515MA-BR423T", 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 2, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8883), "TB-X606F 64GB 10.3\" Wi-Fi Tablet - Gri ZA5T0215TR", 2.137m, "Lenovo TAB M10", 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 2, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8885), "64GB 10.2\" WiFi Tablet - MK2K3TU/A Uzay Grisi", 4.939m, "Apple iPad 9. Nesil", 500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created_At", "Description", "Modified_At", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 8, 2, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8887), "32 GB (Samsung Türkiye Garantili)", null, 1.471m, "Samsung Galaxy Tab A7 Lite", 93 },
                    { 11, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8889), "128 GB 6 GB Ram (Xiaomi Türkiye Garantili)", null, 4.469m, "Xiaomi Redmi Note 10S", 21 },
                    { 12, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8892), "128 GB (Samsung Türkiye Garantili)", null, 2.499m, "Samsung Galaxy M22", 300 },
                    { 13, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8894), "(TCL Türkiye Garantili)", null, 2.660m, "TCL 10 SE 128", 1200 },
                    { 14, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8896), "16 GB (Reeder Türkiye Garantili)", null, 1.419m, "Reeder P13 Blue Max Lite", 488 },
                    { 15, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8898), "128 GB (Infinix Türkiye Garantili)", null, 2.930m, "Infinix Hot 10T", 50 },
                    { 16, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8900), "(HTC Türkiye Garantili)", null, 2.858m, "HTC Desire 20 Pro", 60 },
                    { 17, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8902), "256 GB", null, 9.499m, "iPhone 13 Pro", 2200 },
                    { 18, 3, new DateTime(2022, 1, 22, 19, 18, 33, 794, DateTimeKind.Local).AddTicks(8904), "128 GB (Oneplus Türkiye Garantili)", null, 4.004m, "Oneplus Nord N10 5G", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 16, 32, 49, 565, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1496), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1499), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1501), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1503), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1510), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Created_At", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, new DateTime(2022, 1, 22, 16, 32, 49, 567, DateTimeKind.Local).AddTicks(1512), "AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar", 9.499m, "Huawei Matebook D 16", 50 });
        }
    }
}
