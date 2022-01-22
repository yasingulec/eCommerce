using AutoMapper;
using eCommerce.MicroService.Managers._CategoryManager;
using eCommerce.MicroService.Models._Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryManager _categoryManager;
        private IMapper _mapper;
        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        //action for getting all the categories
        [HttpGet]
        public async Task<IActionResult> Category()
        {
            var categories = await _categoryManager.GetCategoriesAsync();
            if (categories!=null)
            {
                var categoryResponse = _mapper.Map<List<CategoryResponse>>(categories);
                return Ok(categoryResponse);
            }
            return BadRequest();
        }
    }
}
