using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SuperOffice.Security.Principal;

namespace DevNet.v10.Example
{
    /*
     Dependencies:
    Assemblies:
    - id="SuperOffice.NetServer.Services", version=10.1.1
     */

    class Program
    {
        static void Main(string[] args)
        {
            #region Alternative One
            
            //var services = new ServiceCollection();
            //services
            //    .AddNetServerCore()
            //    .AddSoDatabase()
            //    //.AddSingleton<ILogger, SuperOffice.Logging.SoLogger>()
            //    .AddSingleton<IContextInitializer, ContextInitializer>();

            //var provider = services.BuildServiceProvider(true);
            //provider.RegisterWithNetServer(); 
            
            #endregion


            #region Alternative Two
            
            var host = CreateHostBuilder(args).Build();
            host.Services.RegisterWithNetServer();

            using var soSession = SuperOffice.SoSession.Authenticate("ADM0", "");

            using var agent = new SuperOffice.CRM.Services.ContactAgent();
            var ce = agent.GetMyContact();


            host.RunAsync(); 
            
            #endregion
        }

        static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
           .ConfigureServices((_, services) =>
               services.AddNetServerCore()
                       .AddSoDatabase()
                       .AddSingleton<IContextInitializer, ContextInitializer>()
           );
    }
}
