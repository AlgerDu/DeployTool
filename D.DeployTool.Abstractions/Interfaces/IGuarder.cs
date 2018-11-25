using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 守护者，一个程序一个
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

        /// <summary>
        /// 最后的一些信息，方便再次获取
        /// </summary>
        IDictionary<int, IGuardMessage> Messages { get; }

        /// <summary>
        /// 设置回调
        /// </summary>
        /// <param name="action"></param>
        void SetReportAction(Action<IGuarder, IGuardMessage> action);
    }
}
