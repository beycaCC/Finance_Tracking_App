using Microsoft.EntityFrameworkCore;
using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Interface;
using MoneyTracker.Infrastructure.Persistence;

namespace MoneyTracker.Infrastructure.Repository;

internal class AccountRepository(MoneyTrackerDbContext dbContext) : IAccountRepository
{
    public async Task<Guid> CreateAccountAsync(Account account)
    {
        await dbContext.AddAsync(account);
        await dbContext.SaveChangesAsync();
        return account.Id;
    }

    public async Task<ICollection<Account>> GetAccountsAsync()
    {
        return await dbContext.Accounts.ToListAsync();
    }

    public async Task<Account?> GetAccountByIdAsync(Guid id)
    {
        return await dbContext.Accounts.FirstOrDefaultAsync(a => a.Id == id);
    }

    public Task UpdateAccountAsync(Account account)
    {
        //TODO:
        throw new NotImplementedException();
    }

    public async Task DeleteAccountAsync(Account account)
    {
        dbContext.Remove(account);
        await dbContext.SaveChangesAsync();
    }
}
