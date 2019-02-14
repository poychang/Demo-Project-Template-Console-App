using ConsoleApp.Models;
using Microsoft.Extensions.Options;
using System;

namespace ConsoleApp.Services
{
    public class HelloService
    {
        private AppSettingsModel Config { get;  }

        public HelloService(IOptions<AppSettingsModel> options)
        {
            Config = options.Value;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello World！ {Config.Message}");
        }
    }
}
