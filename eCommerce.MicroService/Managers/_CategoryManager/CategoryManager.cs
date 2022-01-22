using eCommerce.MicroService.Entities;
using eCommerce.MicroService.Repository._CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Managers._CategoryManager
{
    //business logic for category
    public class CategoryManager : ICategoryManager
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository  categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public  async Task<List<Category>> GetCategoriesAsync()
        {
            var products = await _categoryRepository.GetAllAsync();
            return products.ToList();
        }
    }
}
