using eCommerce.Web.Helpers;
using eCommerce.Web.Helpers.ViewRenderer;
using eCommerce.Web.Models;
using eCommerce.Web.Services;
using eCommerce.Web.Services.ClientServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductClient _productClient;
        private IViewRenderService _viewRenderService;

        public HomeController(IProductClient productClient, IViewRenderService viewRenderService)
        {
            _productClient = productClient;
            _viewRenderService = viewRenderService;
        }
        public async Task<IActionResult> GetCategories()
        {
            var categories =await _productClient.GetCategories();
            string content = await _viewRenderService.RenderToStringAsync("Category", categories);
            return Content(content);
        }
        public async Task <IActionResult> GetProducts()
        {
            var products =await _productClient.GetProducts();
            string content =await _viewRenderService.RenderToStringAsync("Product", products);

            return Content(content);
        }

        [HttpPost]
         public async Task <IActionResult> GetProductsByCategory([FromBody]ProductQuery query)
        {
            var products = await _productClient.GetProductsByCategory(query);
            string content =await _viewRenderService.RenderToStringAsync("Product", products);

            return Content(content);
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
