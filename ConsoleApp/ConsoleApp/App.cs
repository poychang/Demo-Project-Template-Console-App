using ConsoleApp.Services;

namespace ConsoleApp
{
    public class App
    {
        private readonly HelloService _service;

        public App(HelloService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.SayHello();
        }
    }
}
