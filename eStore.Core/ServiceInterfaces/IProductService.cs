using eStore.Core.Entities;

namespace eStore.Core.ServiceInterfaces;

public interface IProductService
{
    Task<Product> GetProductById(int id);
    Task<ProductBrand> GetProductBrandById(int id);
    Task<ProductType> GetProductTypeById(int id);
    Task<IReadOnlyList<Product>> GetAllProducts();
    Task<IReadOnlyList<ProductBrand>> GetAllProductBrands();
    Task<IReadOnlyList<ProductType>> GetAllProductTypes();

}