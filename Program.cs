using System.Web.Http.SelfHost;
using System.Web.Http;
using System;

namespace SelfHostServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:4547");

            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();

            Console.ReadLine();
        }
    }
}
