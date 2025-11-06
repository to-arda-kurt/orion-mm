using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cart;

public static class CartModule
{
    public static IServiceCollection AddCartModule(
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

    public static IApplicationBuilder UseCartModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Cart module
        // app.Use...

        return app;
    }
}
