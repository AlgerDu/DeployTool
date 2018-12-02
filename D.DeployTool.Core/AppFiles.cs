using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class AppFiles : IAppFiles
    {
        public IAppFile Exectue { get; set; }

        public IEnumerable<IAppFile> Configs { get; set; }

        public IEnumerable<IAppFile> Others { get; set; }
    }
}
