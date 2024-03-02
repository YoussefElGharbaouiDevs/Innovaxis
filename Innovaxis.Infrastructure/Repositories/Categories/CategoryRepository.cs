using Innovaxis.Domain.Models;
using Innovaxis.Infrastructure.Common;
using Innovaxis.Infrastructure.Context;

namespace Innovaxis.Infrastructure.Repositories.Categories;

public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
{
    public CategoryRepository(InnovaxisDbContext innovaxisDbContext) : base(innovaxisDbContext)
    {
    }
}