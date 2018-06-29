using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:9999";

            //Starts the webapp using the configuration we defined in the startup method
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopped");
            };
        }
    }

    public class Startup
    {
        // Tells the server how to communicate to http requests
        public void Configuration(IAppBuilder app)
        {

            app.UseWelcomePage();
            //Katana calls the method for all http requests
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hello World");
            });
        }
    }
}
