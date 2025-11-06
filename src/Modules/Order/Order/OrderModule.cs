using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Order;

public static class OrderModule
{
    public static IServiceCollection AddOrderModule(
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

    public static IApplicationBuilder UseOrderModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Order module
        // app.Use...

        return app;
    }
}
