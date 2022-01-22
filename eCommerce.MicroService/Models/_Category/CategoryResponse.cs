using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Models._Category
{
    //domain transfer object for category
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
