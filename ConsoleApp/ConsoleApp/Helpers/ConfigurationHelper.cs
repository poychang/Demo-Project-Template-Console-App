using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp.Helpers
{
    public static class ConfigurationHelper
    {
        /// <summary>
        /// 讀取組態檔
        /// </summary>
        /// <returns></returns>
        public static IConfigurationRoot AppSettings() =>
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT")}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
    }
}
