using MoneyTracker.Domain.Enum;

namespace MoneyTracker.Application.Dtos.Categories;

public class GetAccountWCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public AccountType AccountType { get; set; }
}
