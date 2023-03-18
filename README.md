# Clean Blazor Template for .NET


This is a solution template for creating a Blazor WebAssembly application hosted on ASP.NET Core 7 and following the principles of Clean Architecture.



## Getting Started
The solution template requires the latest version of [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0).

Install the project template:

```bash
dotnet new install sahinhurcan.CleanBlazor
```

Create a new app:

```bash
dotnet new clean-blazor-sln --output CleanBlazor123
```

Launch the app:
```bash
cd CleanBlazor123\src\WebUI\Server
dotnet run
```

## Database
### Configuration
The template is currently configured to use [SQL Server Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16) for development and [Azure SQL](https://learn.microsoft.com/en-us/azure/azure-sql/database/sql-database-paas-overview?view=azuresql) once deployed. I understand this will be difficult for some developers, and will look other options in the near future.

### Migrations
The template uses Entity Framework Core and migrations can be run using the EF Core CLI Tools. Install the tools using the following command:

```bash
dotnet tool install --global dotnet-ef
```

Once installed, create a new migration with the following commands:

```bash
cd src\Infrastructure
dotnet ef migrations add "Initial" --startup-project ..\WebUI\Server
```

Review the [Entity Framework Core tools reference - .NET Core CLI | Microsoft Docs](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) to learn more.

## License
This project is licensed with the [MIT license](https://github.com/sahinhurcan/CleanBlazor/blob/master/LICENSE).
