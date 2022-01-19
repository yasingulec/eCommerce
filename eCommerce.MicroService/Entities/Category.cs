using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        //relation tanımı 
        public ICollection<Product> Products { get; set; }
    }
}
