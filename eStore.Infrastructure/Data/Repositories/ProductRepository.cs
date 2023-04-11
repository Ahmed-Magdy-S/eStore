using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext Context)
        {
            _context = Context;
        }

        
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }   

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }


    }
}
