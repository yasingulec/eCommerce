using eCommerce.MicroService.Data;
using eCommerce.MicroService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Repository._ProductRepository
{
    //repository for product context
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        private EcommerceDbContext _dbContext;
        public ProductRepository(EcommerceDbContext dbContext) :base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int id)
        {
           return await _dbContext.Products.Include(x => x.Category).Where(x=>x.CategoryId==id).AsNoTracking().ToListAsync();
        }
    }
}
