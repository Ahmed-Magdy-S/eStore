using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using eStore.Core.Specifications;
using eStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Repositories;

public class SpecificationRepository<T> : CrudRepository<T>, ISpecificationRepository<T> where T:BaseEntity
{
    
    public SpecificationRepository(ApplicationContext context) : base(context)
    {
    }
    
    public async Task<T> GetEntityWithSpecification(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).FirstAsync();
    }

    public async Task<IReadOnlyList<T>> ListAsyncWithSpecification(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).ToListAsync();
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        return SpecificationEvaluator<T>.GetQuery(Context.Set<T>().AsQueryable(), spec);
    }
}