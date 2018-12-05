using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.DeployTool
{
    /// <summary>
    /// WinService Code 的枚举
    /// </summary>
    internal enum WinServiceMessageCode
    {
        /// <summary>
        /// 运行正常
        /// </summary>
        Run_OK = 11100,

        Run_Not = 11101,

        Run_StartFaildTimes = 11102,
        Run_StopAfterStartTimes = 11103,
        Run_NotInstalled = 11104,
        Run_ExePathNotMatch = 11105,

        Config_OK = 12200
    }
}
