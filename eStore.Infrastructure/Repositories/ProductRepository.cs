using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repositories;

    public class ProductRepository : CrudRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext applicationContext) : base(applicationContext){}
    }

