using eStore.Core.Entities;

namespace eStore.Core.Specifications;

public sealed class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
{
    
    public ProductsWithTypesAndBrandsSpecification()
    {
        AddInclude(x=>x.ProductType);
        AddInclude(x=>x.ProductBrand);
    }
}