using eStore.Core.ServiceInterfaces;
using eStore.Infrastructure.Services;

namespace eStore.API.Extensions;

public static class ServiceInjection
{
    public static void AddServices(this IServiceCollection service)
    {
        service.AddScoped<IProductService, ProductService>();
    }
}