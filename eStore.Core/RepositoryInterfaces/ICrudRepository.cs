using eStore.Core.Entities;

namespace eStore.Core.RepositoryInterfaces;

public interface ICrudRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAllAsync();
}