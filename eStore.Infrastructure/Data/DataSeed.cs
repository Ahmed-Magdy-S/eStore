using eStore.Core.Entities;
using System.Text.Json;

namespace eStore.Infrastructure.Data
{
    public static class DataSeed
    {
        public static async Task Seed(ApplicationContext context)
        {
            if (!context.Products.Any())
            {
                var productsJson = File.ReadAllText("../eStore.Infrastructure/Data/SeedData/products.json");
                var products =  JsonSerializer.Deserialize<List<Product>>(productsJson);
                if (products != null) await context.Products.AddRangeAsync(products);

            }

            if (!context.ProductBrands.Any())
            {
                var productBrandsJson = File.ReadAllText("../eStore.Infrastructure/Data/SeedData/brands.json");
                var productBrands = JsonSerializer.Deserialize<List<ProductBrand>>(productBrandsJson);
                if (productBrands != null) await context.ProductBrands.AddRangeAsync(productBrands);
            }

            if (!context.ProductTypes.Any())
            {
                var productTypesJson = File.ReadAllText("../eStore.Infrastructure/Data/SeedData/types.json");
                var productTypes = JsonSerializer.Deserialize<List<ProductType>>(productTypesJson);
                if (productTypes != null) await context.ProductTypes.AddRangeAsync(productTypes);
            }

            if (context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }
        }
    }
}
