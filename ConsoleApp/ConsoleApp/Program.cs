using ConsoleApp.Helpers;
using ConsoleApp.Models;
using ConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp
{
    public static class Program
    {
        private static IConfiguration Configuration { get; set; }
        private static IServiceCollection ServiceCollection { get; set; }
        private static IServiceProvider ServiceProvider { get; set; }

        public static void Main(string[] args)
        {
            Configuration = ConfigurationHelper.AppSettings();
            ServiceCollection = new ServiceCollection().ConfigureServices();
            ServiceProvider = ServiceCollection.BuildServiceProvider();

            ServiceProvider.GetRequiredService<App>().Run();
        }

        /// <summary>
        /// 設定依賴服務
        /// </summary>
        /// <param name="services">依賴服務容器</param>
        private static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<AppSettingsModel>(Configuration);

            services.AddTransient<App>();
            services.AddTransient<HelloService>();

            return services;
        }
    }
}
