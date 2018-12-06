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

        /// <summary>
        /// 未运行
        /// </summary>
        Run_Not = 11101,

        /// <summary>
        /// 多次自动启动失败
        /// </summary>
        Run_StartFaildTimes = 11102,

        /// <summary>
        /// 多次启动成功后，短时间崩溃
        /// </summary>
        Run_StopAfterStartTimes = 11103,

        /// <summary>
        /// 未安装
        /// </summary>
        Run_NotInstalled = 11104,

        /// <summary>
        /// 安装，但执行文件路径不匹配
        /// </summary>
        Run_ExePathNotMatch = 11105,

        Config_OK = 12200,

        Config_Not = 12201
    }
}
