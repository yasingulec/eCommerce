using eCommerce.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Services.ClientServices
{
   public interface IProductClient
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductsByCategory(ProductQuery query);
        Task<List<Category>> GetCategories();
    }
}
