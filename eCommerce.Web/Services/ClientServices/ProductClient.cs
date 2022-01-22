using eCommerce.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Web.Services.ClientServices
{
    public class ProductClient:IProductClient
    {
        private HttpClient _client;
        public ProductClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://localhost:22748/api/");
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
        }

        public async Task<List<Product>> GetProducts()
        {
            using (var response = await _client.GetAsync("Product", HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                string strResponse = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(strResponse);
                return products;
            }
        }

        public async Task<List<Category>> GetCategories()
        {
            using (var response = await _client.GetAsync("Category", HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                string strResponse = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<Category>>(strResponse);
                return categories;
            }
        }

        public async Task<List<Product>> GetProductsByCategory(ProductQuery query)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(query),Encoding.UTF8,"application/json");
            using (var response = await _client.PostAsync("Product", stringContent))
            {
                response.EnsureSuccessStatusCode();
                string stream = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(stream);
                return products;
            }
        }
    }
}
