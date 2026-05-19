namespace MoneyTracker.Application.Dtos.Categories;

public class CreateCategoryDto
{
    public required string Name { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}
