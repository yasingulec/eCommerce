using eCommerce.MicroService.Entities;
using eCommerce.MicroService.Repository._ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Managers._ProductManager
{
    //business logic for product
    public class ProductManager : IProductManager
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
           var products= await _productRepository.GetAllAsync();
            return products.ToList();
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int id)
        {
            var products = await _productRepository.GetProductsByCategoryIdAsync(id);
            return products.ToList();
        }
    }
}
