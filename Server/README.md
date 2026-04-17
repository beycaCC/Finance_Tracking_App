# MoneyTracker Backend

ASP.NET Core backend for the MoneyTracker application using PostgreSQL and Entity Framework Core.

## 🚀 Setup

### 1. Start Database (Docker)

```bash
docker compose up -d
```

### 2. Configure Connection

Ensure `appsettings.json` has:
```
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5433;Database=moneytrackerdb;Username=moneytracker;Password=moneytracker123"
}
```

### 3. Run Migrations
```bash
dotnet ef migrations add InitialCreate \
  --project src/MoneyTracker.Infrastructure \
  --startup-project src/MoneyTracker.Api

dotnet ef database update \
  --project src/MoneyTracker.Infrastructure \
  --startup-project src/MoneyTracker.Api
```

or (in Package Manager Console)
```bash
Add-Migration <Message>

Update-Database
```


