﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AwesomeSauce.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration(config => config.AddJsonFile("appSettings.json"))
                .ConfigureLogging(logging => logging.AddConsole().AddDebug())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
        }
            //WebHost.CreateDefaultBuilder(args)
            //    .UseStartup<Startup>()
            //    .Build();
    }
}
