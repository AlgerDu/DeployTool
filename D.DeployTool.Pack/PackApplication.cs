using Autofac;
using D.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool.Pack
{
    /// <summary>
    /// 程序启动、初始化等动作
    /// </summary>
    public class PackApplication : IApplication
    {
        ILogger _logger;

        public PackApplication(
            ILogger<PackApplication> logger
            //, ILifetimeScope lifetimeScope
            )
        {
            _logger = logger;

            //ViewModels.ViewModelLocator.LifetimeScope = lifetimeScope;
        }

        public IApplication Run()
        {
            _logger.LogInformation("deploy pack tool run");
            return this;
        }

        public IApplication Stop()
        {
            _logger.LogInformation("deploy pack tool stop");
            return this;
        }
    }
}
