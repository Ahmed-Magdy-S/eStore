using eStore.Core.Entities;
using eStore.Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure;

public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
{
    public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
    {
        IQueryable<TEntity> query = inputQuery;
        query = query.Where(spec.Criteria);
        query = spec.Includes.Aggregate(
            query,
            (current, include) => current.Include(include)
        );

        return query;
    }
}