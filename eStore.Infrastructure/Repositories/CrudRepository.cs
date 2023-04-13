using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Repositories;

public class CrudRepository<T> : ICrudRepository<T> where T:BaseEntity
{
    protected readonly ApplicationContext Context;

    protected CrudRepository(ApplicationContext context)
    {
        Context = context;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await Context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await Context.Set<T>().ToListAsync();
    }
}