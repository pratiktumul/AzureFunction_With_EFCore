using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Data;

[assembly: FunctionsStartup(typeof(Demo.Startup))]

namespace Demo
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var context = builder.GetContext();
            string connectionString = context.Configuration.GetConnectionString("DataEntities");

            builder.Services.AddDbContext<EmployeeDbContext>(
               options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
        }
    }
}
