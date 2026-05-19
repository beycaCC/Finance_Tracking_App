using MoneyTracker.Application.Dtos.Categories;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Application.Mappers;

public class CategoryMapper
{
    public static GetCategoryDto ToDto(Category category)
    {
        return new GetCategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            CreatedOn = category.CreatedOn,
            Accounts = category.Accounts?.Select(a => new GetAccountWCategoryDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList()
        };
    }

    public static Category ToModel(CreateCategoryDto dto)
    {
        return new Category
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            CreatedOn = dto.CreatedOn
        };
    }
}
