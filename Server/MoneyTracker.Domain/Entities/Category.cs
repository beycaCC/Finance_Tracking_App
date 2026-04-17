namespace MoneyTracker.Domain.Entities;

public class Category
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    // Navigation property
    public ICollection<Account> Accounts { get; set; } = new List<Account>();
}
