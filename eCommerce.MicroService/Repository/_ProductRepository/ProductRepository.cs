using eCommerce.MicroService.Data;
using eCommerce.MicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Repository._ProductRepository
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(EcommerceDbContext ctx):base(ctx)
        {

        }
    }
}
