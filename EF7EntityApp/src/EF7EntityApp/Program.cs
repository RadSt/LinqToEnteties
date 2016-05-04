using System;
using Nancy.Hosting.Self;

namespace EF7EntityApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string url = "http://localhost:8888";

            var uri = new Uri(url);
            var hostConfig = new HostConfiguration
            {
                RewriteLocalhost = true,
                UrlReservations = new UrlReservations {CreateAutomatically = true}
            };
            var host = new NancyHost(hostConfig, uri);

            try
            {
                host.Start();
                Console.WriteLine("Nancy App Started");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception on start host: {ex.Message}{Environment.NewLine}{Environment.StackTrace}");
            }

            Console.ReadKey();
            host.Stop();
        }
    }
}