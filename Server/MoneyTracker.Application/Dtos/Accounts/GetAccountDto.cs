using MoneyTracker.Domain.Entities;
using MoneyTracker.Domain.Enum;

namespace MoneyTracker.Application.Dtos.Accounts;

public class GetAccountDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public AccountType AccountType { get; set; }  // TODO: decide how to seperate the types of accounts, maybe use enum or a separate table
    public decimal Balance { get; set; }

    public DateTime CreatedOn { get; set; }

    // FK
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
}
