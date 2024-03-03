using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Categories;
using Innovaxis.Infrastructure.Common;
using Innovaxis.Infrastructure.Data.Context;

namespace Innovaxis.Infrastructure.Repositories.Categories;

public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
{
    public CategoryRepository(InnovaxisDbContext innovaxisDbContext) : base(innovaxisDbContext)
    {
    }
}