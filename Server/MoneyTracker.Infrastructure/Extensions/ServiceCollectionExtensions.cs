using Microsoft.Extensions.DependencyInjection;
using MoneyTracker.Domain.Interface;
using MoneyTracker.Infrastructure.Repository;

namespace MoneyTracker.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        return services;
    }
}
