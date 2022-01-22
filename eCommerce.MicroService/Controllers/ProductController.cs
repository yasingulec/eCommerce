using AutoMapper;
using eCommerce.MicroService.Managers._ProductManager;
using eCommerce.MicroService.Models._Product;
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
    public class ProductController : ControllerBase
    {
        //constructor injection 

        private IProductManager _productManager;
        private IMapper _mapper;
        public ProductController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }
        //get the all products
        [HttpGet]
        public async Task<IActionResult> Product()
        {
            var products = await _productManager.GetProductsAsync();
            if (products != null)
            {
                var productsReponse = _mapper.Map<List<ProductResponse>>(products);
                return Ok(productsReponse);
            }
            return BadRequest();
        }

        //gets products by category id
        [HttpPost]
        public async Task<IActionResult> ProductsByCategory(ProductQueryRequest query)
        {
            var products = await _productManager.GetProductsByCategoryIdAsync(query.Id);
            if (products != null)
            {
                var productsReponse = _mapper.Map<List<ProductByCategoryResponse>>(products);
                return Ok(productsReponse);
            }
            return BadRequest();
        }

    }
}
