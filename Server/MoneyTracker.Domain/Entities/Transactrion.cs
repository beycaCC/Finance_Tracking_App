using MoneyTracker.Domain.Enum;

namespace MoneyTracker.Domain.Entities;

public class Transactrion
{
    public Guid Id { get; set; }
    public required string Receiver { get; set; }
    public required decimal Amount { get; set; }
    public TransactionType TransactionType { get; set; } // Expense, Income, Transfer

    // FK
    public Guid AccountId { get; set; }

    // navigation property
    public Account Account { get; set; } = default!;

}
