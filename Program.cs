namespace MonitorModule
{
    using System;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    class Program
    {
        public static int counter;

        static void Main(string[] args)
        {
            Module module = new Module();
            module.Initialize(args);
            // BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:4243")
                .Build();

    }
}
