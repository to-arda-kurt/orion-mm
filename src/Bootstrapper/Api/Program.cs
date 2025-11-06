using Cart;
using Catalog;
using Order;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Services
    .AddCatalogModule(builder.Configuration)
    .AddCartModule(builder.Configuration)
    .AddOrderModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app
    .UseCatalogModule()
    .UseCartModule()
    .UseOrderModule();

app.Run();
