using System;
using AutoMapper;
using ProductData.Entity.Dto;

namespace ProductData.Entity.Mapper
{
    public class ProductMapper: Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductDto>().ReverseMap()
                .ForMember(dest => dest.CreatedDT, opt => opt.Ignore());
            CreateMap<ProductAttribute, ProductAttributesDto>().ReverseMap()
                .ForMember(dest => dest.CreatedDT, opt => opt.Ignore());
        }
    }
}
