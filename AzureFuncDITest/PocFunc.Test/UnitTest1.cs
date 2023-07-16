using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using PocFunc.Test.Models;
using Company.Function;

namespace PocFunc.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new TestDbSet();
            HttpTrigger1 httpTrigger1 = new HttpTrigger1(mock._repo.Object);
            var logger = NullLoggerFactory.Instance.CreateLogger("Null Logger");
            var result = httpTrigger1.Run(null, logger);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
