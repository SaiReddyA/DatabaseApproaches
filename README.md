#  Code First EF Core Example (.NET Core)

This project demonstrates the **Code First approach** in **.NET Core with Entity Framework Core**.
You will learn how to:
* Define model classes
* Configure DbContext 
* Run migrations
---


## Tech Stack
* **.NET Core 6/7/8/9**
* **Entity Framework Core**
* **SQL Server**
---
## 📂 Project Setup
### 1️ Clone the Repository
```bash
git clone https://github.com/SaiReddyA/DatabaseApproaches.git
cd DatabaseApproaches
```

### 2️⃣ Install NuGet Packages

Make sure these packages are installed:

```bash
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```

Or via `dotnet` CLI:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

## 🏗 Database Setup

### 3️⃣ Configure Connection String

Update `appsettings.json` with your SQL Server details:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=SRCodeFirstDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
}
```

---

### 4️⃣ Add DbContext in `Program.cs`

```csharp
builder.Services.AddDbContext<SRCodeFirstContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

---

### 5️⃣ Run Migrations

Generate the initial migration:

```bash
Add-Migration InitialCreate
```

Apply it to the database:

```bash
Update-Database
```

---

