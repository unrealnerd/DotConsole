using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace DotConsole
{
    
public class App
    {
        private readonly IConfiguration _config;

        public App(IConfiguration config)
        {
            _config = config;
        }

        public async Task Run(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~Welcome~~~~~~~~~~~~");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(_config.GetSection("Message").Value);
            Console.ReadKey();
        }
    }
}