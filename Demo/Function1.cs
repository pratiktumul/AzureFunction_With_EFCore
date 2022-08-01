using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace Demo
{
    public class Function1
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public Function1(EmployeeDbContext employeeDbContext)
        {
           _employeeDbContext = employeeDbContext;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var data = _employeeDbContext.Person.ToList();

            return new OkObjectResult(data);
        }
    }
}
