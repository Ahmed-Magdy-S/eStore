using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repositories;

    public class ProductRepository : SpecificationRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationContext applicationContext) : base(applicationContext){}
    }

