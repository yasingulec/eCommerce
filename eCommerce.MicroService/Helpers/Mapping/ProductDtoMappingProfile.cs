using AutoMapper;
using eCommerce.MicroService.Entities;
using eCommerce.MicroService.Models._Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.MicroService.Helpers.Mapping
{
    public class ProductDtoMappingProfile:Profile
    {
        public ProductDtoMappingProfile()
        {
            CreateMap<Product, ProductResponse>();
        }
    }
}
