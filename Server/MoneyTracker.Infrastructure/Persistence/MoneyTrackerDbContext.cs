using Microsoft.EntityFrameworkCore;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Infrastructure.Persistence;

public class MoneyTrackerDbContext : DbContext
{
    public MoneyTrackerDbContext(DbContextOptions<MoneyTrackerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transactrion> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Account>()
            .HasMany(t => t.Transactions)
            .WithOne(a => a.Account)
            .HasForeignKey(t => t.AccountId);


        modelBuilder.Entity<Category>()
            .HasMany(t => t.Accounts)
            .WithOne(c => c.Category)
            .HasForeignKey(t => t.CategoryId);
    }
}