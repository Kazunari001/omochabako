using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Company.Function.Models;

namespace Company.Function
{
    public class HttpTrigger1
    {
        private readonly IUserRepository _repo;

        public HttpTrigger1(IUserRepository repo)
        {
            _repo = repo;
        }

        [FunctionName("HttpTrigger1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var users = _repo.GetAll();
            string responseMessage = JsonConvert.SerializeObject(users);
            return new OkObjectResult(responseMessage);
        }
    }
}
