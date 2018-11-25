using System;
using System.Collections.Generic;
using System.Text;

namespace D.DeployTool
{
    /// <summary>
    /// 命令
    /// </summary>
    public interface IGuarderCommand
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        Guid Uid { get; }

        /// <summary>
        /// 时间戳
        /// </summary>
        DateTimeOffset TimeStamp { get; }
    }
}
