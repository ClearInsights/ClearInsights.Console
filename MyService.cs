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

        public MyService(ILogger<MyService> logger)
        {
            Logger = logger;
        }

        public async Task ProcessComplete()
        {
            var metric = new DynamicMetric("{ApiKey}", "{Environment Client Secret}");
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
            var metric = new DynamicMetric("{ApiKey}", "{Environment Client Secret}");
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
