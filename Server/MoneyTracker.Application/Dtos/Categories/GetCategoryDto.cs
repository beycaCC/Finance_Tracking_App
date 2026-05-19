using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Application.Dtos.Categories;

public class GetCategoryDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public ICollection<GetAccountWCategoryDto>? Accounts { get; set; }
}
