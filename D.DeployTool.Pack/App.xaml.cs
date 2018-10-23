using D.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace D.DeployTool.Pack
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static PackApplication Core { get; private set; }

        public App()
        {
            Core = new ApplicationBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureLogging((config, logging) =>
                {
                    logging.AddConfiguration(config.GetSection("logging"));
                    logging.AddRollingFile(config.GetSection("Logging:RollingFile"));
                })
                .Use<Startup>()
                .Builde<PackApplication>();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Core.Stop();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Core.Run();
        }
    }
}
