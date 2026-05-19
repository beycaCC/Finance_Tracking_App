using Microsoft.EntityFrameworkCore;
using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interface;
using MoneyTracker.Infrastructure.Persistence;

namespace MoneyTracker.Infrastructure.Repository;

internal class CategoryRepository(MoneyTrackerDbContext dbContext) : ICategoryRepository
{
    public async Task<Guid> CreateCategoryAsync(Category category)
    {
        await dbContext.Categories.AddAsync(category);
        await dbContext.SaveChangesAsync();
        return category.Id;
    }

    public async Task<ICollection<Category>> GetCategoryAsync()
    {
        return await dbContext.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryByIdAsync(Guid id)
    {
        return await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        dbContext.Categories.Update(category);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(Category category)
    {
        dbContext.Categories.Remove(category);
        await dbContext.SaveChangesAsync();
    }
}
