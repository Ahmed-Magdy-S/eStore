using eStore.Core.Entities;

namespace eStore.Core.RepositoryInterfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetProductsAsync();

        Task<Product?> GetProductByIdAsync(int id);

        Task<ProductBrand> GetProductBrandsAsync();

        Task<ProductType> GetProductTypesAsync();

    }
}
