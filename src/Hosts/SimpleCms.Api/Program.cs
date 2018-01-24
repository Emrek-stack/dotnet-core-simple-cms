using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;

namespace SimpleCms.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "ApiServer";
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Warning);
                    builder.AddFilter("ApiServer", LogLevel.Debug);
                })
                .UseKestrel()
                .UseUrls("http://localhost:8484")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
    }
}
