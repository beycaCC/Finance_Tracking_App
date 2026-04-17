

using Microsoft.EntityFrameworkCore;
using MoneyTracker.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Customized Dependency Injection
builder.Services.AddDbContext<MoneyTrackerDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


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
