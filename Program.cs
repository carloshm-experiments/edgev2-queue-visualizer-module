namespace MonitorModule
{
    using System;
    using System.IO;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    class Program
    {
        public static int counter;

        static void Main(string[] args)
        {
            Console.WriteLine($"Current Directory = {Directory.GetCurrentDirectory()}");
            Module module = new Module();
            module.Initialize(args);
            // BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://*:4243")
                .UseStartup<Startup>()
                .Build();

    }
}
