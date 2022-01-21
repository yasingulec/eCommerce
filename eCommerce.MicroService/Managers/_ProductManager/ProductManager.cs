using eCommerce.MicroService.Entities;
using eCommerce.MicroService.Repository._ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Managers._ProductManager
{
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
    }
}
