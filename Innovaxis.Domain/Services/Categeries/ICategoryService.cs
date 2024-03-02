using Innovaxis.Domain.Models;

namespace Innovaxis.Domain.Services.Categeries;

public interface ICategoryService
{
    Task<IEnumerable<CategoryEntity>> FindAllCategoriesAsync();

    Task<CategoryEntity?> FindACategoryAsync(Guid id);

    Task AddCategoryAsync(CategoryEntity category);

    Task AddCategoriesAsync(IEnumerable<CategoryEntity> categories);

    Task UpdateCategoryAsync(CategoryEntity category);

    Task UpdateCategoriesAsync(IEnumerable<CategoryEntity> categories);

    Task RemoveCategoryAsync(CategoryEntity category);

    Task RemoveCategoriesRange(IEnumerable<CategoryEntity> categories);
}