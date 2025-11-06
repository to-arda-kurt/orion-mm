using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Register services for the Catalog module
        // services
        //     .AddApplicationServices()
        //     .AddInfrastructureServices(configuration)
        //     .AddApiServices();

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Catalog module
        // app.Use...

        return app;
    }
}
