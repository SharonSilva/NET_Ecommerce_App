using AutoMapper;
using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.DTOs.Product;
using eCommerceApp.Domain.Entities;
using CreateCategory = eCommerceApp.Application.DTOs.Product.CreateCategory;

namespace eCommerceApp.Application.Mapping;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<CreateCategory, Category>();
        CreateMap<CreateProduct, Product>();

        CreateMap<Category, GetCategory>();
        CreateMap<Product, GetProduct>();
    }
}