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

    public async Task<IEnumerable<CategoryEntity>> FindAllCategoriesAsync()
    {
        return await _categoryRepository.FindAllAsync();
    }

    public async Task<CategoryEntity?> FindACategoryAsync(Guid id)
    {
        return await _categoryRepository.FindAsync(id);
    }

    public async Task AddCategoryAsync(CategoryEntity category)
    {
        await _categoryRepository.AddAsync(category);
    }

    public async Task AddCategoriesAsync(IEnumerable<CategoryEntity> categories)
    {
        await _categoryRepository.AddRangeAsync(categories);
    }

    public async Task UpdateCategoryAsync(CategoryEntity category)
    {
        await _categoryRepository.UpdateAsync(category);
    }

    public async Task UpdateCategoriesAsync(IEnumerable<CategoryEntity> categories)
    {
        await _categoryRepository.UpdateRangeAsync(categories);
    }

    public async Task RemoveCategoryAsync(CategoryEntity category)
    {
        await _categoryRepository.RemoveAsync(category);
    }

    public async Task RemoveCategoriesRange(IEnumerable<CategoryEntity> categories)
    {
        await _categoryRepository.RemoveRange(categories);
    }
}