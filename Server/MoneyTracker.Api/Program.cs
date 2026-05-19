

using Microsoft.EntityFrameworkCore;
using MoneyTracker.Infrastructure.Persistence;
using MoneyTracker.Infrastructure.Extensions;
using AutoMapper;
using MoneyTracker.Application.Dtos.Categories;
using MoneyTracker.Application.Dtos.Accounts;

var builder = WebApplication.CreateBuilder(args);

// Customized Dependency Injection
builder.Services.AddDbContext<MoneyTrackerDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register infrastructure services (repositories, etc.)
builder.Services.AddInfrastructure();

// Configure AutoMapper manually (avoid dependency on AddAutoMapper extension)
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CategoryProfile());
    mc.AddProfile(new AccountProfile());
});
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Default Dependency Injections
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
