using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Domain.Interface;

public interface ICategoryRepository
{
    Task<ICollection<Category>> GetCategoryAsync();
    Task<Category?> GetCategoryByIdAsync(Guid id);
    Task<Guid> CreateCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(Category category);
}
