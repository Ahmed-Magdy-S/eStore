using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repositories;

public class ProductBrandRepository : CrudRepository<ProductBrand>, IProductBrandRepository
{
    public ProductBrandRepository(ApplicationContext applicationContext): base(applicationContext){}
}