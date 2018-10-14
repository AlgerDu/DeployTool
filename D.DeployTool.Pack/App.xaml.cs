using D.Utils;
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

                })
                .ConfigureLogging((config, logging) =>
                {

                })
                .Use<Startup>()
                .Builde<PackApplication>();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Core.Run();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Core.Stop();
        }
    }
}
