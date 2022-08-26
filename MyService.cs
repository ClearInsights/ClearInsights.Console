using ClearInsights.Monitoring.Metric;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ClearInsights.Console
{
    public interface IMyService
    {
        Task ProcessComplete();
        Task ProcessCompleteWithError();
    }
    public class MyService : IMyService
    {
        protected ILogger Logger;

        public MyService(ILogger<MyService> logger) => Logger = logger;

        public async Task ProcessComplete()
        {
            var metric = new DynamicMetric("e645fe78-e2b3-11ec-8f8e-000d3a4384cb", "bQ7Qh/fWdbXthRNuHoDPzOJJPCn5vSFTEjk7yHlGgLDT7eLcFK2h+2h3W0LCMjgcBTjqC9Ns+NlTrmYqi58eVA==");
            var person = new Person()
            {
                Name = "",
                Address = ""
            };
            metric.SetPayload(JsonConvert.SerializeObject(person));
            await metric.SendAsync();
            Logger.LogInformation("MyService Process Complete");
        }

        public async Task ProcessCompleteWithError()
        {
            var metric = new DynamicMetric("e645fe78-e2b3-11ec-8f8e-000d3a4384cb", "bQ7Qh/fWdbXthRNuHoDPzOJJPCn5vSFTEjk7yHlGgLDT7eLcFK2h+2h3W0LCMjgcBTjqC9Ns+NlTrmYqi58eVA==");
            await metric.SendAsync();
            throw new Exception("Sample Exception");
        }
    }

    public class Person
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
