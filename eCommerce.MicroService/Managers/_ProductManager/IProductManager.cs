using eCommerce.MicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Managers._ProductManager
{
    public interface IProductManager
    {
        Task<List<Product>> GetProductsAsync();
    }
}
