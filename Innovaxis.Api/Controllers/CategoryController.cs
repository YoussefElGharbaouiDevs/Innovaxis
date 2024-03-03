using System.Net.Mime;
using AutoMapper;
using Innovaxis.Api.Dtos;
using Innovaxis.Domain.Models;
using Innovaxis.Domain.Services.Categeries;
using Microsoft.AspNetCore.Mvc;

namespace Innovaxis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<CategoryEntity>>> GetCategories()
        {
            return Ok(await _categoryService.FindAllCategoriesAsync());
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoryEntity>> GetCategory(Guid id)
        {
            var category = await _categoryService.FindACategoryAsync(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoryDto>> CreateCategory(CategoryDto categoryDto)
        {
            if (categoryDto == null)
            {
                return BadRequest("Category data is invalid.");
            }

            var categoryEntity = _mapper.Map<CategoryEntity>(categoryDto);

            await _categoryService.AddCategoryAsync(categoryEntity);

            return CreatedAtAction(nameof(GetCategory), new { id = categoryEntity.Id }, categoryDto);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCategory(Guid id, CategoryDto categoryDto)
        {
            if (id != categoryDto.Id)
            {
                return BadRequest();
            }

            var existingCategory = await _categoryService.FindACategoryAsync(id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            var categoryEntity = _mapper.Map<CategoryEntity>(categoryDto);
            categoryEntity.Id = id;

            await _categoryService.UpdateCategoryAsync(categoryEntity);

            return NoContent();
        }


        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var existingCategory = await _categoryService.FindACategoryAsync(id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            await _categoryService.RemoveCategoryAsync(existingCategory);

            return NoContent();
        }
    }
}