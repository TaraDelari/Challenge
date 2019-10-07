using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;

namespace Challenge.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SetupLogger();
            IWebHost host = BuildWebHost(args);
            host.Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog()
                .Build();

        private static void SetupLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.File(new RenderedCompactJsonFormatter(), Path.Combine(AppContext.BaseDirectory, "ChallengeLogs", "logs.txt"))
                .CreateLogger();
        }
    }
}
