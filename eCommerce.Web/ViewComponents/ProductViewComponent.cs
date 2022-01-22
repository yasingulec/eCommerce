using eCommerce.Web.Models;
using eCommerce.Web.Services.ClientServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
       private IProductClient _productClient;
        public ProductViewComponent(IProductClient productClient)
        {
            _productClient = productClient;
        }
        public async Task <IViewComponentResult> Invoke()
        {
            List<Product> products = await _productClient.GetProducts();
            return View(products);
        }
    }
}
