using eCommerce.MicroService.Data;
using eCommerce.MicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Repository._CategoryRepository
{
    //repository for category context
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        private EcommerceDbContext _dbContext;

        public CategoryRepository(EcommerceDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
