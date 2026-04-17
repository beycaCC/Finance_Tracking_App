using MoneyTracker.Domain.Enum;
using MoneyTracker.Domain.Enums;

namespace MoneyTracker.Domain.Entities;

public class Account
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public AccountType AccountType { get; set; }  // TODO: decide how to seperate the types of accounts, maybe use enum or a separate table
    public decimal Balance { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    // FK
    public Guid CategoryId { get; set; }

    // navigation property
    public ICollection<Transactrion> Transactions { get; set; } = new List<Transactrion>();
    public Category Category { get; set; }
}
