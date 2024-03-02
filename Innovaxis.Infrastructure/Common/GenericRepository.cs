using Innovaxis.Domain.Repositories;
using Innovaxis.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Innovaxis.Infrastructure.Common;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly InnovaxisDbContext _innovaxisDbContext;

    public GenericRepository(InnovaxisDbContext innovaxisDbContext)
    {
        _innovaxisDbContext = innovaxisDbContext ?? throw new ArgumentNullException(nameof(innovaxisDbContext));
    }

    public async Task<IEnumerable<T>> FindAllAsync()
    {
        return await _innovaxisDbContext.Set<T>().ToListAsync();
    }

    public virtual async Task<T?> FindAsync(Guid id)
    {
        return await _innovaxisDbContext.Set<T>().FindAsync(id);
    }

    public virtual async Task AddAsync(T entity)
    {
        await _innovaxisDbContext.Set<T>().AddAsync(entity);
    }

    public virtual async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _innovaxisDbContext.AddRangeAsync(entities);
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _innovaxisDbContext.Update(entity);
        await _innovaxisDbContext.SaveChangesAsync();
    }

    public virtual async Task UpdateRangeAsync(IEnumerable<T> entities)
    {
        _innovaxisDbContext.UpdateRange(entities);
        await _innovaxisDbContext.SaveChangesAsync();
    }

    public async Task RemoveAsync(T entity)
    {
        _innovaxisDbContext.Remove(entity);
        await _innovaxisDbContext.SaveChangesAsync();
    }

    public async Task RemoveRange(IEnumerable<T> entities)
    {
        _innovaxisDbContext.RemoveRange(entities);
        await _innovaxisDbContext.SaveChangesAsync();
    }
}