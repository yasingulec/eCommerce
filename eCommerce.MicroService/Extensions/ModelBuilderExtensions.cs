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
        //extension method for seed data
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category> { 
                new Category{Id=1,Name="Bilgisayar",Created_At=DateTime.Now}
            });

            modelBuilder.Entity<Product>().HasData(new List<Product> {
                new Product{Id=1,ProductName="Huawei Matebook D 16", CategoryId=1,Description="AMD Ryzen 5 4600H 8GB 512GB SSD Windows 10 Home 16.1\" FHD Taşınabilir Bilgisayar",Quantity=50,Price=9.499M,Created_At=DateTime.Now}
            });
        }
    }
}
