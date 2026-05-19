using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyTracker.Application.Dtos.Categories;
using MoneyTracker.Application.Mappers;
using MoneyTracker.Domain.Interface;

namespace MoneyTracker.Api.Controller;

[ApiController]
[Route("api/categories")]
public class CategoryController(ICategoryRepository repository,
    IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await repository.GetCategoryAsync();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(Guid id)
    {
        var category = await repository.GetCategoryByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
    {
        if (createCategoryDto == null)
        {
            return BadRequest();
        }

        var model = CategoryMapper.ToModel(createCategoryDto);
        var newId = await repository.CreateCategoryAsync(model);

        return CreatedAtAction(
            nameof(GetCategoryById),
            new { id = newId },
            new { id = newId }
        );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] UpdateCategoryDto updateCategoryDto)
    {
        if (updateCategoryDto == null)
        {
            return BadRequest();
        }

        var existing = await repository.GetCategoryByIdAsync(id);
        if (existing == null)
        {
            return NotFound();
        }

        // Map the incoming DTO onto the existing entity and persist changes
        mapper.Map(updateCategoryDto, existing);
        await repository.UpdateCategoryAsync(existing);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        var existing = await repository.GetCategoryByIdAsync(id);
        if (existing == null)
        {
            return NotFound();
        }
        await repository.DeleteCategoryAsync(existing);
        return NoContent();
    }

}
