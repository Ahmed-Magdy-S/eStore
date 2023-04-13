using eStore.Core.Entities;
using eStore.Core.Specifications;

namespace eStore.Core.RepositoryInterfaces;

public interface ISpecificationRepository<T> : ICrudRepository<T> where T : BaseEntity
{
    Task<T> GetEntityWithSpecification(ISpecification<T> spec);

    Task<IReadOnlyList<T>> ListAsyncWithSpecification(ISpecification<T> spec);
}