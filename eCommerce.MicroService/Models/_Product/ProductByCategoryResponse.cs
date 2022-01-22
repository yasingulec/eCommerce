﻿using eCommerce.MicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Models._Product
{
    public class ProductByCategoryResponse
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}
