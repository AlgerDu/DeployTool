using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class AppFile : IAppFile
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string Version { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        public string Size { get; set; }
    }
}
