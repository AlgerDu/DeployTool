using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 守护者
    /// </summary>
    public interface IGuarder
    {
        /// <summary>
        /// 手上的任务
        /// </summary>
        IGuardTask Task { get; }

        /// <summary>
        /// 工作
        /// </summary>
        /// <returns></returns>
        IGuarder Work();

        /// <summary>
        /// 休息
        /// </summary>
        /// <returns></returns>
        IGuarder Reset();

        
    }
}
