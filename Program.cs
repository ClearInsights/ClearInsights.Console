using ClearInsights.Console;
using ClearInsights.Logging;
using ClearInsights.Monitoring;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging(builder =>
        builder.ClearProviders()
            //Add to capture logs with ClearInsights Logging product
            .AddClearInsightsLogger(configuration =>
            {
                configuration.ApiKey = "{ApiKey}";
                configuration.Secret = "{Environment Client Secret}";
                configuration.ApplicationName = "{Application Name}";
            }))
    .ConfigureServices(services =>
    {
        // Add to capture performance metrics with the Monitoring product
        services.AddClearInsightsMonitor(configuration =>
        {
            configuration.ApiKey = "{ApiKey}";
            configuration.Secret = "{Environment Client Secret}";
            configuration.ApplicationName = "{Application Name}";
        });
        services.AddTransient<IMyService, MyService>();
    })
            .Build();
await host.StartAsync();

//Add to use ClearInsights global error handling.
//This will automatically catch any unhandled exceptions
System.AppDomain.CurrentDomain.UseClearInsightsExceptionHandling(host.Services.GetRequiredService<ILogger<Program>>());

var myService = host.Services.GetRequiredService<IMyService>();
await myService.ProcessComplete();
await myService.ProcessCompleteWithError();



