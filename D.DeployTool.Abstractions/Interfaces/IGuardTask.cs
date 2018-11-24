using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 守护任务
    /// </summary>
    public interface IGuardTask
    {
        /// <summary>
        /// 任务 UID，可以用来暂停什么的
        /// </summary>
        Guid Uid { get; }

        /// <summary>
        /// 要守护的应用
        /// </summary>
        IRealApplication App { get; }
    }
}
