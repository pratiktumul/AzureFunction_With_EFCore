Azure Function (Microservice Architecture) with Entity Framework Core

STEPS TO CREATE AN AZURE FUNTION USING ASP.NET CORE WITH ENTITY FRAMEWORK CORE:

1. Create a project of type Azure function using Visual Studio 2019.
2. Install the following packages:
  -> Microsoft.EntityFrameworkCore
  -> Microsoft.EntityFrameworkCore.SqlServer
  -> Microsoft.Azure.Functions.Extensions
3. Create a table in database
4. Configure the connection string(refer to local.settings.json file)
5. Create data model class(refer to Employee.cs file)
6. Create a DBContext class(refer to EmployeeDbContext.cs file)
7. Create a new class & name it as "Startup.cs"(for configuration purpose refer to Startup.cs file)
8. For getting data from your table use your Function.cs file(refer to Function1.cs)

Additionally, Please go through some tutorials on ASP.NET Core with EFCore.
