using eCommerceApp.Application.Services.Interfaces.Logging;
using eCommerceApp.Domain.Entities;
using eCommerceApp.Domain.Interfaces;
using eCommerceApp.Infrastructure.Data;
using eCommerceApp.Infrastructure.MiddleWare;
using eCommerceApp.Infrastructure.Repositories;
using eCommerceApp.Infrastructure.Services;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerceApp.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureService
        (this IServiceCollection services, IConfiguration config)
    {
        string connectionString = "DefaultConnection";
        services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString(connectionString),
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName); 
                        
                    }).UseExceptionProcessor(),
            ServiceLifetime.Scoped);
        services.AddScoped<IGeneric<Product>, GenericRepository<Product>>();
        services.AddScoped<IGeneric<Category>, GenericRepository<Category>>();
        services.AddScoped(typeof(IAppLogger<>), typeof(SerilogLoggerAdapter<>));
        return services;
    }

    public static IApplicationBuilder UseInfrastructureService(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        return app;
    }
}
