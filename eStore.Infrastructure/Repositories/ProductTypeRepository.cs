using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repositories;

public class ProductTypeRepository : CrudRepository<ProductType>, IProductTypeRepository
{
    public ProductTypeRepository(ApplicationContext applicationContext) : base(applicationContext){}
}