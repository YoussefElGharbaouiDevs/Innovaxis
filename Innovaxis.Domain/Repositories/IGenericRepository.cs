namespace Innovaxis.Domain.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> FindAllAsync();

    Task<T?> FindAsync(Guid id);

    Task AddAsync(T entity);

    Task AddRangeAsync(IEnumerable<T> entities);

    Task UpdateAsync(T entity);

    Task UpdateRangeAsync(IEnumerable<T> entities);

    Task RemoveAsync(T entity);

    Task RemoveRange(IEnumerable<T> entities);
}