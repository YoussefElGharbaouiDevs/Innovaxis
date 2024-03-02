using Innovaxis.Domain.Models;
using Innovaxis.Domain.Repositories.Categories;

namespace Innovaxis.Domain.Services.Categeries;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    //TODO : Implement the service methods

    public Task<IEnumerable<CategoryEntity>> FindAllCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryEntity?> FindACategoryAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddCategoryAsync(CategoryEntity category)
    {
        throw new NotImplementedException();
    }

    public Task AddCategoriesAsync(IEnumerable<CategoryEntity> categories)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCategoryAsync(CategoryEntity category)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCategoriesAsync(IEnumerable<CategoryEntity> categories)
    {
        throw new NotImplementedException();
    }

    public Task RemoveCategoryAsync(CategoryEntity category)
    {
        throw new NotImplementedException();
    }

    public Task RemoveCategoriesRange(IEnumerable<CategoryEntity> categories)
    {
        throw new NotImplementedException();
    }
}