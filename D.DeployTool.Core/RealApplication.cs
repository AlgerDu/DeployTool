using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class RealApplication : IRealApplication
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Path { get; set; }

        public AppType Type { get; set; }

        public IDictionary<string, string> RunningParams { get; set; }

        public IEnumerable<IAppConnfigItem> Configs { get; set; }

        public IEnumerable<IEnvironmentRequirement> Environments { get; set; }

        public IAppFiles Files { get; set; }
    }
}
