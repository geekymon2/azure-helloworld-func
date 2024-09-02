using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace GeekyMon2.Function
{
    public class HttpHelloWorld
    {
        private readonly ILogger<HttpHelloWorld> _logger;

        public HttpHelloWorld(ILogger<HttpHelloWorld> logger)
        {
            _logger = logger;
        }

        [Function("HttpHelloWorld")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
