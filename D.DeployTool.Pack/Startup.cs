﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using D.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool.Pack
{
    public class Startup : IStartup
    {
        public ILoggerFactory LoggerFactory { get; set; }
        public IConfiguration Configuration { get; set; }

        public IServiceProvider ConfigService(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);

            return new AutofacServiceProvider(builder.Build());
        }
    }
}
