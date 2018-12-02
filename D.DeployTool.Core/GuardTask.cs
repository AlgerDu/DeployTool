using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    public class GuardTask : IGuardTask
    {
        public Guid Uid { get; set; }

        public IRealApplication App { get; set; }
    }
}
