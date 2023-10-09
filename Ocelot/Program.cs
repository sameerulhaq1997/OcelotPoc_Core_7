using Microsoft.AspNetCore;
using OcelotGateway;

CreateWebHostBuilder(args).Build().Run();


static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((host, config) =>
    {
        config.AddJsonFile("ocelot.json");
    })
    .UseStartup<Startup>();