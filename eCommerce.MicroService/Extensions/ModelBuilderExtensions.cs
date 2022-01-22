using eCommerce.MicroService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Extensions
{
    public static class ModelBuilderExtensions
    {
        //extension method for seed data which used for generating datas
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category> {
                new Category{Id=1,Name="Bilgisayar",Created_At=DateTime.Now},
                 new Category{Id=2,Name="Tablet",Created_At=DateTime.Now},
                  new Category{Id=3,Name="Telefon",Created_At=DateTime.Now},
            });

          
            modelBuilder.Entity<Product>().HasData(new List<Product> {
                new Product{Id=1,ProductName="Huawei Matebook D 16", CategoryId=1,Description="AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar",Quantity=50,Price=9.499M,Created_At=DateTime.Now},
                new Product{Id=2,ProductName="Dell Vostro 3500", CategoryId=1,Description=" Intel Core i3 1115G4 8GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar",Quantity=30,Price=6.499M,Created_At=DateTime.Now},
                new Product{Id=3,ProductName="HP 15S-FQ2038NT", CategoryId=1,Description="Intel Core i3 1115G4 4GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar 2N2N6EA",Quantity=47,Price=5.298M,Created_At=DateTime.Now},
                new Product{Id=4,ProductName="Lenovo Ideapad 1 14IGL05", CategoryId=1,Description="Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.0'' Taşınabilir Bilgisayar",Quantity=83,Price=3.999M,Created_At=DateTime.Now},
                new Product{Id=5,ProductName="Asus X515MA-BR423T", CategoryId=1,Description="Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 15.6\" Taşınabilir Bilgisayar",Quantity=12,Price=3.949M,Created_At=DateTime.Now},
                new Product{Id=6,ProductName="Lenovo TAB M10", CategoryId=2,Description="TB-X606F 64GB 10.3\" Wi-Fi Tablet - Gri ZA5T0215TR",Quantity=150,Price=2.137M,Created_At=DateTime.Now},
                new Product{Id=7,ProductName="Apple iPad 9. Nesil", CategoryId=2,Description="64GB 10.2\" WiFi Tablet - MK2K3TU/A Uzay Grisi",Quantity=500,Price=4.939M,Created_At=DateTime.Now},
                new Product{Id=8,ProductName="Samsung Galaxy Tab A7 Lite", CategoryId=2,Description="32 GB (Samsung Türkiye Garantili)",Quantity=93,Price=1.471M,Created_At=DateTime.Now},
                new Product{Id=11,ProductName="Xiaomi Redmi Note 10S", CategoryId=3,Description="128 GB 6 GB Ram (Xiaomi Türkiye Garantili)",Quantity=21,Price=4.469M,Created_At=DateTime.Now},
                new Product{Id=12,ProductName="Samsung Galaxy M22", CategoryId=3,Description="128 GB (Samsung Türkiye Garantili)",Quantity=300,Price=2.499M,Created_At=DateTime.Now},
                new Product{Id=13,ProductName="TCL 10 SE 128", CategoryId=3,Description="(TCL Türkiye Garantili)",Quantity=1200,Price=2.660M,Created_At=DateTime.Now},
                new Product{Id=14,ProductName="Reeder P13 Blue Max Lite", CategoryId=3,Description="16 GB (Reeder Türkiye Garantili)",Quantity=488,Price=1.419M,Created_At=DateTime.Now},
                new Product{Id=15,ProductName="Infinix Hot 10T", CategoryId=3,Description="128 GB (Infinix Türkiye Garantili)",Quantity=50,Price=2.930M,Created_At=DateTime.Now},
                new Product{Id=16,ProductName="HTC Desire 20 Pro", CategoryId=3,Description="(HTC Türkiye Garantili)",Quantity=60,Price=2.858M,Created_At=DateTime.Now},
                new Product{Id=17,ProductName="iPhone 13 Pro", CategoryId=3,Description="256 GB",Quantity=2200,Price=25.499M,Created_At=DateTime.Now},
                new Product{Id=18,ProductName="Oneplus Nord N10 5G", CategoryId=3,Description="128 GB (Oneplus Türkiye Garantili)",Quantity=50,Price=4.004M,Created_At=DateTime.Now},
               




            });
        }
    }
}
