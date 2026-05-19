using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Domain.Interface;

public interface IAccountRepository
{
        Task<ICollection<Account>> GetAccountsAsync();
        Task<Account?> GetAccountByIdAsync(Guid id);
        Task<Guid> CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(Account account);
}
