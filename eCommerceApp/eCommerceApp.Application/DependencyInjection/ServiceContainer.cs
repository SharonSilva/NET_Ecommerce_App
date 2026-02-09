using eCommerceApp.Application.Mapping;
using eCommerceApp.Application.Services.Interfaces;
using eCommerceApp.Application.Services.implementations;
using Microsoft.Extensions.DependencyInjection;
namespace eCommerceApp.Application.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { }, typeof(MappingConfig).Assembly);
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}