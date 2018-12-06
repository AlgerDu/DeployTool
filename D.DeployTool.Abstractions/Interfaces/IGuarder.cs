using D.Utils;
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
        IGuardTask GTask { get; }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        IResult Execute(IGuarderCommand command);

        /// <summary>
        /// 最后的一些信息，方便再次获取
        /// </summary>
        IDictionary<int, IGuardMessage> Messages { get; }

        /// <summary>
        /// 正在执行的命令
        /// </summary>
        IEnumerable<IGuarderCommand> ExecutintCommands { get; }

        /// <summary>
        /// 设置回调
        /// </summary>
        /// <param name="action"></param>
        void SetReportAction(Action<IGuarder, IGuardMessage> action);
    }
}
