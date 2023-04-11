using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Repositories;

namespace eStore.API.Extensions;

public static class RepositoryInjection
{
    public static void AddRepositories(this IServiceCollection service)
    {
        service.AddScoped<IProductRepository, ProductRepository>();
        service.AddScoped<IProductBrandRepository, ProductBrandRepository>();
        service.AddScoped<IProductTypeRepository, ProductTypeRepository>();
    }
}