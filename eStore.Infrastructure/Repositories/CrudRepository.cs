using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Repositories;

public class CrudRepository<T> : ICrudRepository<T> where T:BaseEntity
{
    private readonly ApplicationContext _context;

    public CrudRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
}