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
}