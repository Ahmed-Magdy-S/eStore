using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Core.ServiceInterfaces;
using eStore.Core.Specifications;

namespace eStore.Infrastructure.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IProductBrandRepository _productBrandRepository;
    private readonly IProductTypeRepository _productTypeRepository;

    public ProductService(
        IProductRepository productRepository ,
        IProductBrandRepository productBrandRepository,
        IProductTypeRepository productTypeRepository
        )
    {
        _productRepository = productRepository;
        _productBrandRepository = productBrandRepository;
        _productTypeRepository = productTypeRepository;
    }
    
    public async Task<Product> GetProductById(int id)
    {
        Product? product = await _productRepository.GetByIdAsync(id);
        if (product == null) throw new Exception("Product Not Found");
        return product;
    }

    public async Task<ProductBrand> GetProductBrandById(int id)
    {
        ProductBrand? product = await _productBrandRepository.GetByIdAsync(id);
        if (product == null) throw new Exception("Product Brand Not Found");
        return product;
        
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        ProductType? product = await _productTypeRepository.GetByIdAsync(id);
        if (product == null) throw new Exception("Product Type Not Found");
        return product;    }

    public async Task<IReadOnlyList<Product>> GetAllProducts()
    {
        var spec = new ProductsWithTypesAndBrandsSpecification();
        return await _productRepository.ListAsyncWithSpecification(spec);
    }

    public async Task<IReadOnlyList<ProductBrand>> GetAllProductBrands()
    {
        return await _productBrandRepository.ListAllAsync();
    }

    public async Task<IReadOnlyList<ProductType>> GetAllProductTypes()
    {
        return await _productTypeRepository.ListAllAsync();
    }
}